using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    
    [ApiController]
    public class DescargaController : Controller
    {
        [Route("api")]
        [HttpPost]
        public async Task<IActionResult>  Descargas(List<IFormFile> files)
        {
            foreach(var formfile in files)
            {
                //cambiar la carpeta temporal por una que establezcamos la ubicacion nosotros
                var filepath = Path.GetTempFileName();
                using (var stream=System.IO.File.Create(filepath))
                {
                    await formfile.CopyToAsync(stream);
                }
            }

            return Ok();
            
        }
        [Route("api/file")]
        [HttpPost]
        public async Task<IActionResult> Descarga([FromForm] FileModel file)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);
            using(Stream stream=new FileStream(path,FileMode.Create))
            {
                await file.FormFile.CopyToAsync(stream);
            }

            return Ok();
        }
        [Route("api/file")]
        [HttpGet]
        public IActionResult Get([FromForm] FileModel file)
        {
            //string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);
            //using (Stream stream = new FileStream(path, FileMode.Create))
            //{
            //    await file.FormFile.CopyToAsync(stream);
            //}

            
            return Ok();
        }
    }
}
