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
        const string DownloadUrl = "https://s3-ap-southeast-2.amazonaws.com/s.santhakumar/Resume/Santha+kumar+Resume.docx";
        const string WordContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

            [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAsync()
        {

            var httpClient = new HttpClient();

            var httpResponseMessage = await httpClient.GetStreamAsync(DownloadUrl);

            return File(httpResponseMessage, WordContentType);
        }
    }
}
}
