using FirstApi.Model;
using System;

namespace FirstApi.Repository
{
    public class SocialPlatformTranslationServices : ISocialPlatformTranslation
    {
        private DBContext _DB;
        public SocialPlatformTranslationServices(DBContext DB)
        {
            _DB = DB;
        }
        public SocialPlatformTranslations GetSocialPlatformTranslations(int LanguageKey, int SocialPlatformKey)
        {
            try
            {
                var SPT = _DB.Find<SocialPlatformTranslations>(SocialPlatformKey, LanguageKey);
                return SPT;
            }
            catch
            {
                return null;
            }
        }
        public Response AddSocialPlatformTranslations(SocialPlatformTranslations SPT)
        {
            Response response = new Response();
            try
            {
                SocialPlatformTranslations SPTranslation = GetSocialPlatformTranslations(SPT.LanguageKey, SPT.SocialPlatformKey);
                if (SPTranslation == null)
                {

                    _DB.Add<SocialPlatformTranslations>(SPT);
                    _DB.SaveChanges();
                    response.Message = "Added Successfully";
                    response.Success = true;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Already Exist !";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
               
            }
            return response;

        }


    }
}
