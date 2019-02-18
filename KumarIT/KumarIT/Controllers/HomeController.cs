using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
namespace KumarIT.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            WebClient client = new WebClient();
            string address = "https://s3-ap-southeast-2.amazonaws.com/s.santhakumar/Resume/Santha+kumar+Resume.docx";

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = desktop + "\\Santha Kumar Resume.docx";
            client.DownloadFile(address, fileName);
     
            return "Santha Kumar Resume Downloaded";
        }
    }
}