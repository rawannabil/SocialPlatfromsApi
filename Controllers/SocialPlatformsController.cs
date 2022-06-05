using FirstApi.Model;
using FirstApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    public class SocialPlatformsController : Controller
    {
        ISocialPlatfromsServices _SocialPlatfromsServices;
        ISocialPlatformTranslation _SocialPlatformTranslation;
      
        public SocialPlatformsController(ISocialPlatfromsServices Services, ISocialPlatformTranslation TServices)
        {
            _SocialPlatfromsServices = Services;
            _SocialPlatformTranslation = TServices;

        }
        [Route("Social/All")]
        public IActionResult Index()
        {
            try
            {
                var SocialPlatfroms = _SocialPlatfromsServices.GetSocialPlatfromsList();
                if (SocialPlatfroms != null)
                    return Ok(SocialPlatfroms);
                else
                    return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }

        [Route("Api/Add")]
        [HttpPost]
        public IActionResult Post([FromBody] SocialPlatformTranslations SPT)
        {
            try
            {
                var response = _SocialPlatformTranslation.AddSocialPlatformTranslations(SPT);
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }
        // GET: SocialPlatformsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SocialPlatformsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocialPlatformsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SocialPlatformsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SocialPlatformsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SocialPlatformsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SocialPlatformsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
