using FirstApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace FirstApi.Repository
{
    public interface ISocialPlatfromsServices
    {
        IQueryable<SocialWithTranslation> GetSocialPlatfromsList();
    }
}
