using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Storefront.DATA.EF;

namespace Storefront.UI.MVC.Controllers
{
    public class VideoGamesController : Controller
    {
        private StoreFrontMainEntities db = new StoreFrontMainEntities();

        // GET: VideoGames
        public ActionResult Index()
        {
            var videoGames = db.VideoGames.Include(v => v.ESRBRating).Include(v => v.Genre).Include(v => v.Publisher);
            return View(videoGames.ToList());
        }

        // GET: VideoGames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoGame videoGame = db.VideoGames.Find(id);
            if (videoGame == null)
            {
                return HttpNotFound();
            }
            return View(videoGame);
        }

        // GET: VideoGames/Create
        public ActionResult Create()
        {
            ViewBag.ESRBRatingID = new SelectList(db.ESRBRatings, "ESRBRatingID", "Rating");
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Genre1");
            ViewBag.PublisherID = new SelectList(db.Publishers, "PublisherID", "PublisherName");
            return View();
        }

        // POST: VideoGames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VidGameID,Upc,VideoGameTitle,Description,ESRBRatingID,GenreID,PublisherID,Price,PublishDate,CreatorID,Image,InStock,UnitsSold,OnBackOrder")] VideoGame videoGame)
        {
            if (ModelState.IsValid)
            {
                db.VideoGames.Add(videoGame);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ESRBRatingID = new SelectList(db.ESRBRatings, "ESRBRatingID", "Rating", videoGame.ESRBRatingID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Genre1", videoGame.GenreID);
            ViewBag.PublisherID = new SelectList(db.Publishers, "PublisherID", "PublisherName", videoGame.PublisherID);
            return View(videoGame);
        }

        // GET: VideoGames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoGame videoGame = db.VideoGames.Find(id);
            if (videoGame == null)
            {
                return HttpNotFound();
            }
            ViewBag.ESRBRatingID = new SelectList(db.ESRBRatings, "ESRBRatingID", "Rating", videoGame.ESRBRatingID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Genre1", videoGame.GenreID);
            ViewBag.PublisherID = new SelectList(db.Publishers, "PublisherID", "PublisherName", videoGame.PublisherID);
            return View(videoGame);
        }

        // POST: VideoGames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VidGameID,Upc,VideoGameTitle,Description,ESRBRatingID,GenreID,PublisherID,Price,PublishDate,CreatorID,Image,InStock,UnitsSold,OnBackOrder")] VideoGame videoGame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(videoGame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ESRBRatingID = new SelectList(db.ESRBRatings, "ESRBRatingID", "Rating", videoGame.ESRBRatingID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Genre1", videoGame.GenreID);
            ViewBag.PublisherID = new SelectList(db.Publishers, "PublisherID", "PublisherName", videoGame.PublisherID);
            return View(videoGame);
        }

        // GET: VideoGames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoGame videoGame = db.VideoGames.Find(id);
            if (videoGame == null)
            {
                return HttpNotFound();
            }
            return View(videoGame);
        }

        // POST: VideoGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VideoGame videoGame = db.VideoGames.Find(id);
            db.VideoGames.Remove(videoGame);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
