using Microsoft.AspNetCore.Mvc;
using Projects.models;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController: ControllerBase
    {
        [HttpGet]
        [Route("")]
        public  IActionResult GetProjects()
        {
            var projects = new List<Project>
{
            new Project
            {
                Id = 1,
                Title = "Compatibility Checker",
                Category = "Web Application",
                Description = "Responsive application that determines whether a device is compatible with selected applications, with manual search and QR-based device identification",
                Technologies = new List<string>
                {
                    "Next.JS",
                    "React.JS",
                    "TypeScript",
                    "Hooks",
                    "Tailwind CSS"
                },
                Image = "/images/scottdunn.png",
                Href = "#"
            },

            new Project
            {
                Id = 2,
                Title = "OneID Portal",
                Category = "SaaS / Dashboard",
                Description = "Administrative web portal for managing a mobile application and its operational workflows",
                Technologies = new List<string>
                {
                    "React.JS",
                    "React-Admin",
                    "Hooks",
                    "Material UI"
                },
                Image = "/images/scottdunn.png",
                Href = "#"
            },

            new Project
            {
                Id = 3,
                Title = "ScottDunn",
                Category = "Marketing Website",
                Description = "Luxury travel website presenting premium holiday experiences across ski destinations, safari lodges and expedition cruises.",
                Technologies = new List<string>
                {
                    "HTML5",
                    "CSS3",
                    "JavaScript"
                },
                Image = "/images/scottdunn.png",
                Href = "#"
            }
        };

            return Ok(projects);
        }
    }
}
