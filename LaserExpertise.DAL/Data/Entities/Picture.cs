using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LaserExpertise.DAL.Data.Entities
{
    public class Picture
    {
        [HiddenInput(DisplayValue = false)]
        public int PictureID { get; set; }

        [Required(ErrorMessage = "Please enter a picture name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }

        public byte[] ImageData { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get; set; }
    }
}
