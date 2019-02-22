using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using KumarResumeAPI.Controllers;

namespace KumarIT.Controllers
{
    public class HomeController : ControllerBase
    {
        public async Task<ActionResult> IndexAsync()
        {
            KumarResumeAPI.Controllers.CvServiceController resume = new KumarResumeAPI.Controllers.CvServiceController();
            resume.GetAsync();
         return null;
        }
    }
}