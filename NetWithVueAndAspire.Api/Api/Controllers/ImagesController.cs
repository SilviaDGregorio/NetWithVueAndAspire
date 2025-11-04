using Microsoft.AspNetCore.Mvc;
using NetWithVueAndAspire.Api.Model;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController : ControllerBase
    {
        [HttpGet(Name = "GetImages")]
        public IEnumerable<Image> Get()
        {
            return new[]
            {
                // local image (place a file at Api/wwwroot/images/sample1.jpg to use this)
                new Image { Url = $"https://i.etsystatic.com/33504850/r/il/a541d3/7210909158/il_1588xN.7210909158_484l.jpg", Description = "Pumpkin pattern" },

                // placeholder remote images — these work immediately without local files
                new Image { Url = "https://i.etsystatic.com/21971696/r/il/492e61/3926048546/il_1588xN.3926048546_1n29.jpg", Description = "Bambi" },
                new Image { Url = "https://i.etsystatic.com/52435180/r/il/8b046a/6230483443/il_1588xN.6230483443_cqqe.jpg", Description = "Ratón" },
            };
        }
    }
}