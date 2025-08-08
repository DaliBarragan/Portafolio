using Portafolio.Models;
namespace Portafolio.Services
{
    public class RepositoryProjects
    {
        public List<ProjectViewModel> ObtainProjects()
        {
            return new List<ProjectViewModel>()
            {
                new ProjectViewModel{
                    Title = "Dabora Software",
                    Description = "ERP for Companies",
                    Link = "https://www.daborasoft.com",
                    ImgUrl = "/images/daborasoft.png"
                }
            };
        }
    }
}