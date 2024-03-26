using Microsoft.AspNetCore.Mvc;

namespace StockWizImgAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly ILogger<ImageController> _logger;

        public ImageController(ILogger<ImageController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetImage")]
        public IActionResult Get(string ticker)
        {
            var file = System.IO.File.ReadAllLines(".env");
            string url = file[0] + ticker + ".png";

            Byte[] b = System.IO.File.ReadAllBytes(url);         
            return File(b, "image/jpeg");
        }
    }
}
