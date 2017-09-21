using System.Data.Entity;
using LaserExpertise.DAL.Data;
namespace LaserExpertise.DAL.EF
{
    public class LaserExpertiseContext : DbContext
    {
        public LaserExpertiseContext()
            : base("LaserExpertiseContext")
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<ARTWORK_GENRE> ArtworkGenres { get; set; }
        public DbSet<ARTWORK> Artworks { get; set; }
        public DbSet<ARTWORK_TYPE_POSITION> ArtworkTypePositions { get; set; }
        public DbSet<AUTHOR> Authors { get; set; }
        public DbSet<CHEMICAL_ELEMENT> ChemicalElements { get; set; }
        public DbSet<CITY> Citys { get; set; }
        public DbSet<COUNTRY> Countrys { get; set; }
        public DbSet<CREATION_DATE> CreationDates { get; set; }
        public DbSet<DATE_REMARKS> DateRemarks { get; set; }
        public DbSet<EPOCH> Epochs { get; set; }
        public DbSet<FOCUS_SECTION_SpectralResearch_> FocusSectionSpectralResearch_S { get; set; }
        public DbSet<FOTO> Fotos { get; set; }
        public DbSet<HISTORICAL_PERIOD> HistoricalPeriods { get; set; }
        public DbSet<INSTRUMENTAL_METHODS> InstrumentalMethods { get; set; }
        public DbSet<LIBRARY_OF_SPEKTR_LINES> LibraryOfSpektrLines { get; set; }
        public DbSet<LOCATION> Locations { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<PAINTING_SCHOOL> PaintingSchools { get; set; }
        public DbSet<PAINTING_STYLE> PaintingStyles { get; set; }
        public DbSet<PAINTING_TECHNIQUE> PaintingTechniques { get; set; }
        public DbSet<PAINTS> Paints { get; set; }
        public DbSet<PASSPORT_RESEARCH> PassportResearchs { get; set; }
        public DbSet<PIGMENTS> Pigments { get; set; }
        public DbSet<POSITION> Positions { get; set; }
        public DbSet<Privileges> Privilegeses { get; set; }
        public DbSet<SPEKTR> Spektrs { get; set; }
        public DbSet<SPEKTR_LINE> SpektrLines { get; set; }
    }
}
