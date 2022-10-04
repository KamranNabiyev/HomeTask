using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Extensions
{
    public static class Extension
    {
        public static bool IsImage(this IFormFile photo)
        {
            return photo.ContentType.Contains("image/");
        }
        public static bool IsSizeAllowed(this IFormFile file, int kb)
        {
            return file.Length < 1000 * kb;
        }

    }
}
