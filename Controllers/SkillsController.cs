using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        //GET: /skills
        [HttpGet]
        [Route("/skills")] 
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding Skills to Learn</h2>" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        //GET: /skills/form
        [HttpGet("/skills/form")]
        //POST: /skills/form
        [HttpPost("/skills/form")]
        [Route("/skills/form")]
        public IActionResult LearningProgress()
        {
            string html = "<form method='post' action='/skills/form/'>" +
               "<label>Date:</label></br>" +
               "<input type='date' name='startDate' />" +
               "</br></br>" +
               "<label>C#:</label></br>" +
               "<select name='Level' id='Level - select'>" +
                    "<option value=''>--Please select a Level--</option>" +
                    "<option value='Learning basics'>Learning basics</option>" +
                    "<option value='Making apps'>Making apps</option>" +
                    "<option value='Master Coder'>Master Coder</option>" +
               "</select>" +
               "</br></br>" +
               "<label>JavaScript:</label></br>" +
               "<select name='Level' id='Level - select'>" +
                    "<option value='JS'>--Please select a Level--</option>" +
                    "<option value='Learning basics'>Learning basics</option>" +
                    "<option value='Making apps'>Making apps</option>" +
                    "<option value='Master Coder'>Master Coder</option>" +
               "</select>" +
               "</br></br>" +
               "<label>Python:</label></br>" +
               "<select name='Level' id='Level - select'>" +
                    "<option value=''>--Please select a Level--</option>" +
                    "<option value='Learning basics'>Learning basics</option>" +
                    "<option value='Making apps'>Making apps</option>" +
                    "<option value='Master Coder'>Master Coder</option>" +
               "</select>" +
               "</br></br>" +
               "<input type='submit' value='Submit' />" +
               "</form>";
            return Content(html, "text/html");
        }
    }
}
