using FirstApi.Model;
using FirstApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialPlatfromTranslationController : ControllerBase
    {

        ISocialPlatformTranslation _SocialPlatformTranslation;
        public SocialPlatfromTranslationController(ISocialPlatformTranslation Services)
        {
            _SocialPlatformTranslation = Services;
        }


        // GET: api/<SocialPlatfromTranslationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SocialPlatfromTranslationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SocialPlatfromTranslationController>
        [Route("Api/Add")]
        [Produces("application/json")]
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

        // PUT api/<SocialPlatfromTranslationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SocialPlatfromTranslationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
