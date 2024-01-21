using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetProjects()
        {
            var projects = new List<Project>
        {
            new Project { Name = "AnnonsWebApi", GitHubLink = "https://github.com/agaquit/AnnonsWebApi" },
            new Project { Name = "WebBankApplication", GitHubLink = "https://github.com/agaquit/WebBankApplication" },
            new Project { Name = "CarSimulator", GitHubLink = "https://github.com/agaquit/CarSimulator" },
        };

            return Ok(projects);
        }
    }

    public class Project
    {
        public string Name { get; set; }
        public string GitHubLink { get; set; }
    }
}

