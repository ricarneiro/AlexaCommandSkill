using CommandApi.Models;

namespace CommandApi.Actions
{
    public class FavoriteIntent
    {
        public AlexaResponse FavoriteBandIntentHandler()
        {
            var favoriteBand = "unknown.";

            var response = new AlexaResponse("Your favorite band is " + favoriteBand + ".");
            response.Response.ShouldEndSession = true;
            return response;
        }
    }
}
