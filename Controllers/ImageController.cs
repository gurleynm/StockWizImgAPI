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
            Byte[] b = System.IO.File.ReadAllBytes(ticker+".jpg");   // You can use your own method over here.         
            return File(b, "image/jpeg");
        }
    }
}
