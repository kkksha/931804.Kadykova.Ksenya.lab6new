using System;
using Microsoft.AspNetCore.Http;

namespace lastWeb.Models
{
    public class FileViewModel
    {
        public string Name { get; set; }
        public IFormFile FilePath { get; set; }
    }
}
