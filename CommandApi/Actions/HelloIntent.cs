using CommandApi.Models;

namespace CommandApi.Actions
{
    public class HelloIntent
    {
        public AlexaResponse HelloIntentHandler()
        {
            var response = new AlexaResponse("Hello from My Company.");
            response.Response.Reprompt.OutputSpeech.Text =
                "You can tell me to say hello, what is my favorite band, or cancel to exit.";
            response.Response.ShouldEndSession = false;
            return response;
        }
    }
}
