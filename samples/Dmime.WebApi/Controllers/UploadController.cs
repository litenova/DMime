using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Dmime.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dmime.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly IMimeDetector _mimeDetector;

        public UploadController(IMimeDetector mimeDetector)
        {
            _mimeDetector = mimeDetector;
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile formFile)
        {
            var stream = formFile.OpenReadStream();

            var result = await _mimeDetector.DetectAsync(stream);

            return Ok(result);
        }
    }
}