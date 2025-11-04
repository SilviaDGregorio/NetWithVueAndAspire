using Microsoft.EntityFrameworkCore;
using NetWithVueAndAspire.Api.Model;

namespace NetWithVueAndAspire.Api.Services
{
    public class ImageService(EmbroideryDbContext dbContext) : IImageService
    {
        public async Task<IEnumerable<Image>> GetAllImagesAsync()
        {
            return await dbContext.Images.Select(x => new Image() { Url = x.Url, Description = x.Description}).ToListAsync();
        }
    }
}
