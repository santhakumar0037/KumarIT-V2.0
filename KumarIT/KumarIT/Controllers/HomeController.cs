using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;

namespace KumarIT.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task<byte[]> Index(string url)
        {
            using (var client = new HttpClient())
            {
                using (var result = await client.GetAsync("https://s3-ap-southeast-2.amazonaws.com/s.santhakumar/Resume/Santha+kumar+Resume.docx"))
                {
                    if (result.IsSuccessStatusCode) { 
                        var contentStream =  await result.Content.ReadAsStreamAsync();
                        return FileStreamResult(contentStream, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Cv.docx");
                    }
                }                 
            }
            return null;

            //    WebClient client = new WebClient();
            //var address = new Uri("https://s3-ap-southeast-2.amazonaws.com/s.santhakumar/Resume/Santha+kumar+Resume.docx");

            //string fileName = "Santha Kumar Resume.docx";
            //client.DownloadFileAsync(address, fileName);

            // 
            //return Ok();
        }
    }
}