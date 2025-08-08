using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositoryProjects repositoryProjects;

        public HomeController(ILogger<HomeController> logger,
                            RepositoryProjects repositoryProjects)
        {
            _logger = logger;
            this.repositoryProjects = repositoryProjects;
        }

        public IActionResult Index()
        {
            var repositoryProjects = new RepositoryProjects();
            var projects = repositoryProjects.ObtainProjects().ToList();
            var model = new HomeIndexViewModel() { Projects = projects };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
