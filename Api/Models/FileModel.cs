using Microsoft.AspNetCore.Http;

namespace Api.Models
{
    public class FileModel
    {
        public string FileName { get; set; }
        public IFormFile FormFile { get; set; }
    }
}
