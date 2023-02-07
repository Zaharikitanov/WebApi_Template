using CloudTestApi.Database.Models;

namespace CloudTestApi.Services.Interfaces
{
    public interface ICitiesService
    {
        Task<List<Cities>> GetAllAsync();
    }
}