using FirstApi.Model;

namespace FirstApi.Repository
{
    public interface ISocialPlatformTranslation
    {
        SocialPlatformTranslations GetSocialPlatformTranslations(int LanguageKey, int SocialPlatformKey);
        Response AddSocialPlatformTranslations(SocialPlatformTranslations SPT);
    }
}
