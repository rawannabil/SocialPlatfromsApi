using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstApi.Model
{
    public class Languages
    {
        [Key]
        public int Id { set; get; }
        public string Key { set; get; }
        public string Name { set; get; }
        public virtual ICollection<SocialPlatformTranslations> SocialPlatformTranslation { get; set; }

    }
}
