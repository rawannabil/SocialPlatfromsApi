using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApi.Model
{
    public class SocialPlatformTranslations
    {
        [ForeignKey("SocialPlatform")]
        public int SocialPlatformKey { set; get; }
        [ForeignKey("language")]
        public int LanguageKey { set; get; }
        public string Name { set; get; }
        public virtual SocialPlatforms SocialPlatform { get; set; }
        public virtual Languages language { get; set; }


    }
}
