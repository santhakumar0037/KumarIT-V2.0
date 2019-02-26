using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using Microsoft.Extensions.Options;

namespace KumarResumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CvServiceController : ControllerBase
    {
        private readonly ResumeOptions _resumeOptions;

        public CvServiceController(IOptions<ResumeOptions> resumeOptions)
        {
            _resumeOptions = resumeOptions.Value;
        }

        const string WordContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAsync()
        {
            var httpClient = new HttpClient();

            var httpResponseMessage = await httpClient.GetStreamAsync(_resumeOptions.ResumeUrl);

            return File(httpResponseMessage, WordContentType);

        }
    }
}

