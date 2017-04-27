using System.Collections.Generic;
using LaserExpertise.DAL.Models.User;

namespace LaserExpertise.DAL.Models.Artist
{
    public class Artist:User.User
    {
        public string School { get; set; }
        public virtual ICollection<Artwork.Artwork> Artworks { get; set; }
    }
}