using NetWithVueAndAspire.Api.Model;

namespace NetWithVueAndAspire.Api.Services
{
    public interface IImageService
    {
        Task<IEnumerable<Image>> GetAllImagesAsync();
    }
}