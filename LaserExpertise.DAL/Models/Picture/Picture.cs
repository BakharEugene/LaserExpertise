using LaserExpertise.DAL.Models.Artwork;

namespace LaserExpertise.DAL.Models.Picture
{
    public class Picture
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public Picture(string path, Artwork.Artwork artwork)
        {
            this.Path = path;
            this.Artwork = artwork;
        }
        public Picture() { }
        public int? ArtworkId { get; set; }
        public virtual Artwork.Artwork Artwork { get; set; }
    }
}