using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Storefront.DATA.EF//.Metadata
{
    [MetadataType(typeof(VideoGameMetadata))]
    public partial class VideoGame
    {

    }
    public class VideoGameMetadata
    {

        //public int VidGameID { get; set; }
        [StringLength(15)]
        public string Upc { get; set; }
        [StringLength(50)]
        [Required]
        public string VideoGameTitle { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        public int ESRBRatingID { get; set; }
        [Required]
        public int GenreID { get; set; }
        [Required]
        public int PublisherID { get; set; }
        [DisplayFormat(DataFormatString ="{0:c}")]
        public Nullable<decimal> Price { get; set; }
        [Display(Name ="Published")]
        [DisplayFormat(DataFormatString ="{0:d}")]
        public Nullable<System.DateTime> PublishDate { get; set; }
        public Nullable<int> CreatorID { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> InStock { get; set; }
        public Nullable<int> UnitsSold { get; set; }
        public Nullable<bool> OnBackOrder { get; set; }
    }
}
