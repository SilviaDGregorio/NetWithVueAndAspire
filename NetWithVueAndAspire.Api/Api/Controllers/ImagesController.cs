using Microsoft.AspNetCore.Mvc;
using NetWithVueAndAspire.Api.Model;
using NetWithVueAndAspire.Api.Services;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController(IImageService imageService) : ControllerBase
    {
        [HttpGet(Name = "GetImages")]
        public async Task<IEnumerable<Image>> Get()
        {
            return await imageService.GetAllImagesAsync();
        }
    }
}