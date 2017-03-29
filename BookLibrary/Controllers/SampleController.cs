using BookLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BookLibrary.Controllers
{
    public class SampleController : Controller
    {
        [HttpGet]
        public string Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return "Hello " + User.Identity.Name;
            }
            return "Hello guest.";
            
        }
        [HttpPost("UploadFile")]
        public async Task<IActionResult> Post(HttpPostedFileBase f)
        {
            // long size = f.Length;

            // full path to file in temp location
            // var filePath = Path.GetTempFileName();
            
                // if (f.Length > 0)
                // {
                //     using (var stream = new FileStream(filePath, FileMode.Create))
                //     {
                //         await f.CopyToAsync(stream);
                //     }
                // }
            

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { "OK" });
        }
        public IActionResult Upload()
        {
            return View();
        }
    }
}