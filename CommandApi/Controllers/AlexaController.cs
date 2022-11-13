using CommandApi.Actions;
using CommandApi.Models;
using Microsoft.AspNetCore.Mvc;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace CommandApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlexaController : ControllerBase
    {
        private readonly ILogger<AlexaController> logger;
        private readonly FavoriteIntent favoriteIntent;
        private readonly HelloIntent helloIntent;

        public AlexaController(ILogger<AlexaController> logger)
        {
            this.logger = logger;
            this.favoriteIntent = new FavoriteIntent();
            this.helloIntent = new HelloIntent();
        }

        [Route("companyskill")]
        [HttpPost]
        public AlexaResponse MyCompanySkill(AlexaRequest requestApi)
        {
            AlexaResponse response = null;

            switch (requestApi.Request.Intent.Name)
            {
                case "HelloIntent":
                    response = helloIntent.HelloIntentHandler();
                    break;
                case "FavoriteBandIntent":
                    response = favoriteIntent.FavoriteBandIntentHandler();
                    break;
                default:
                    response = helloIntent.HelloIntentHandler();
                    break;
            }

            return response;
        }
    }
}