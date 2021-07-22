using Microsoft.AspNetCore.Mvc;


namespace HelloASPDotNET.Controllers
{
    [Route("/hello")]
    public class HelloController : Controller
    {
        //GET: /<controller>
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/welcome'/ id='Select a langugage'>" +
                "<label>Name: </label>" +
                "<input type='text' name='name' />" +
                "<label>Select a langugage</label>" +
                "<select name ='language'><option value='English'>English</option><option value='Spanish'>Spanish</option><option value='French'>French</option><option value='Italian'>Italian</option><option value='German'>German</option></select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpGet("/welcome/{name?}")]
        [HttpPost]
        [Route("/welcome")]
        public IActionResult Welcome(string name, string language)
        {
            if (language == "English")
            {
                return Content("<h1>Hello, " + name + "</h1>", "text/html");
            }

            else if (language == "Spanish")
            {
                return Content("<h1>Hola, " + name + "</h1>", "text/html");

            }
            else if (language == "French")
            {
                return Content("<h1>Bonjour, " + name + "</h1>", "text/html");
            }
            else if (language == "Italian")
            {
                return Content("<h1>Ciao, " + name + "</h1>", "text/html");
            }
            else if (language == "German")
            {
                return Content("<h1>Guten Tag, " + name + "</h1>", "text/html");
            }
            else
            {
                return Content("<h1>Hello, " + name + "</h1>", "text/html");

            }
        }

        //public static CreateMessage(string name, string language)
        //{
        //    return Content(name, language);
        //}
    }
}
