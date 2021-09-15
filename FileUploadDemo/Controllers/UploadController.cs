using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadDemo.Controllers
{
    public class FileUploadController : Controller
    {
        [HttpGet("FileUpload2")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("FileUpload2")]
        public async Task<IActionResult> Index(List<IFormFile> files)
        {
            long size = files.Sum(x => x.Length);

            var filePaths = new List<string>();

            foreach(var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    var filePath = Path.GetTempFileName();
                    filePaths.Add(filePath);

                    using(var stream=new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            return Ok(new {count=files.Count,size,filePaths });

        }
    }
}
