using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Net.Http.Headers;

namespace KumarIT.Controllers
{
    public class HomeController : ControllerBase
    {
        const string DownloadUrl = "https://s3-ap-southeast-2.amazonaws.com/s.santhakumar/Resume/Santha+kumar+Resume.docx";
        const string WordContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();


            var httpResponseMessage = await httpClient.GetStreamAsync(DownloadUrl);

            return File(httpResponseMessage, WordContentType);
        }
    }
}