using FirstApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace FirstApi.Repository
{
    public class SocialPlatfromsServices : ISocialPlatfromsServices
    {
        private DBContext _DB;
        public SocialPlatfromsServices(DBContext DB)
        {
            _DB = DB;
        }
        public IQueryable<SocialWithTranslation> GetSocialPlatfromsList()
        {
            try
            {
                var db = _DB.Set<SocialPlatforms>().ToList();
                IQueryable<SocialWithTranslation> result = from SocialPlatforms in _DB.Set<SocialPlatforms>()
                             join Translation in _DB.Set<SocialPlatformTranslations>() on SocialPlatforms.Id equals Translation.SocialPlatformKey 
                             select new SocialWithTranslation
                             {
                                 Id = SocialPlatforms.Id,
                                 Key = SocialPlatforms.Key,
                                 Name = Translation.Name,
                                 DateCreated = SocialPlatforms.DateCreated
                                 
                             };
                

                return result;
            }
            catch 
            {
                return null;            
            }

           
        }
    }
}
