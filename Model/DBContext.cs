using Microsoft.EntityFrameworkCore;

namespace FirstApi.Model
{
    public class DBContext :DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
        : base(options)
        { }
        DbSet<SocialPlatforms> SocialPlatforms { set; get; }
        DbSet<SocialPlatformTranslations> SocialPlatformTranslations { set; get; }
        DbSet<Languages> Languages { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SocialPlatformTranslations>().HasKey(SP => new { SP.SocialPlatformKey, SP.LanguageKey });




            modelBuilder.Entity<SocialPlatforms>().HasData(
                new SocialPlatforms
                {
                    Id=2,
                    Key = "Twitter",
                    DateCreated = System.DateTime.Now
                },
                 new SocialPlatforms
                 {
                     Id = 3,
                     Key = "Instagram",
                     DateCreated = System.DateTime.Now
                 },
                  new SocialPlatforms
                  {
                      Id = 4,
                      Key = "Tiktok",
                      DateCreated = System.DateTime.Now
                  }
                ) ;
        }
    }
}
