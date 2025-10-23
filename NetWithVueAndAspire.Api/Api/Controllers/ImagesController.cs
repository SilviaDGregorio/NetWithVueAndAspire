using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController : ControllerBase
    {
        private readonly ILogger<ImagesController> _logger;
        public ImagesController(ILogger<ImagesController> logger) => _logger = logger;

        [HttpGet(Name = "GetImages")]
        public IEnumerable<ImageItem> Get()
        {
            // Build a base URL for local images (if you place files under wwwroot/images)
            var baseUrl = $"{Request.Scheme}://{Request.Host.Value}";

            return new[]
            {
                // local image (place a file at Api/wwwroot/images/sample1.jpg to use this)
                new ImageItem { Url = $"{baseUrl}/images/onesie1.jpg", Description = "Local sample image" },

                // placeholder remote images — these work immediately without local files
                new ImageItem { Url = "https://picsum.photos/seed/1/600/400", Description = "Random photo 1" },
                new ImageItem { Url = "https://picsum.photos/seed/2/600/400", Description = "Random photo 2" },
            };
        }
    }
}