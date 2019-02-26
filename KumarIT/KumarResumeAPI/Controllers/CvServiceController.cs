using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;

namespace KumarResumeAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CvServiceController : ControllerBase
    {
        Resume CvUrl = new Resume();

        const string WordContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAsync()
        {
            var DownloadUrl =  CvUrl.ResumeService();

            var httpClient = new HttpClient();

            var httpResponseMessage = await httpClient.GetStreamAsync(DownloadUrl);

            return File(httpResponseMessage, WordContentType);

        }
    }
}

