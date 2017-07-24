using System.Collections.Generic;
using System.Globalization;

namespace LaserExpertise.DAL.Models.Artwork
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ArtistId { get; set; }
        //public virtual Artist.Artist Artist { get; set; }

        public virtual ICollection<Picture.Picture> Pictures { get; set; }

        
        public string Genre { get; set; }
        public string School { get; set; }
        public string Description { get; set; }
    }
}