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
                Description = "A responsive application that determines whether a device is compatible with selected applications, with manual search and QR-based device identification",
                Technologies = new List<string>
                {
                    "Next.JS",
                    "React.JS",
                    "TypeScript",
                    "Hooks",
                    "Tailwind CSS"
                },
                Responsibilities = new List<string>
                {
                    "Architected reusable React components and UI patterns using React Hooks.",
                    "Implemented Next.js App Router for navigation and static page generation",
                    "Integrated device detection and QR scanning workflows",
                    "Built responsive interfaces optimized for mobile and tablet experiences.",
                    "Structured the UI for maintainability and reuse across compatibility workflows."
                },
                Image = "/images/compatibility-checker.png",
                Href = "#"
            },

            new Project
            {
                Id = 2,
                Title = "OneID Portal",
                Category = "SaaS / Dashboard",
                Description = "Enterprise administrative portal for managing mobile application operations, users, and business workflows through a centralized dashboard.",
                Technologies = new List<string>
                {
                    "React.JS",
                    "React-Admin",
                    "Hooks",
                    "Material UI"
                },
                Responsibilities = new List<string>
                {
                    "Built a scalable administrative portal using React.js and React-admin, providing structured interfaces for application\r\nmanagement and operational workflows.",
                    "Implemented JWT-based authentication with access-token and refresh-token handling for persistent sessions.",
                    "Contributed to CI/CD workflows supporting automated build, testing, and deployment.",
                    "Developed responsive layouts supporting desktop, tablet, and mobile breakpoints across the application.",
                    "Built 20+ reusable React components used across multiple administrative workflows."
                },                
                Image = "",
                Href = "#"
            },

            new Project
            {
                Id = 3,
                Title = "ScottDunn",
                Category = "Marketing Website",
                Description = "A premium travel website showcasing luxury holidays across ski destinations, safari lodges, and expedition cruises, with a strong focus on responsive design and frontend performance.",
                Technologies = new List<string>
                {
                    "HTML5",
                    "CSS3",
                    "JavaScript"
                },
               Responsibilities = new List<string>
               {
                    "Reworked the frontend from the ground up using semantic HTML, CSS, JavaScript, and Sass.",
                    "Developed modular Sass mixins and reusable styling patterns for maintainable CSS architecture.",
                    "Implemented responsive layouts and custom media queries across desktop, tablet, and mobile breakpoints.",
                    "Used Google Lighthouse to identify and address frontend performance opportunities.",
                    "Improved page structure and responsive behavior to provide a consistent experience across devices."
                },

                Image = "/images/scottdunn.png",
                Href = "#"
            }
        };

            return Ok(projects);
        }
    }
}
