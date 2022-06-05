using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstApi.Model
{
    public class SocialPlatforms
    {
        [Key]
        public int Id { set; get; }
        public string Key { set; get; }
        public DateTime DateCreated { set; get; }
        public virtual ICollection<SocialPlatformTranslations> SocialPlatformTranslation { get; set; }



    }
}
