using CloudTestApi.Database;
using CloudTestApi.Database.Models;
using CloudTestApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloudTestApi.Services
{
    public class CitiesService : ICitiesService
    {
        private readonly CloudTestContext _context;

        public CitiesService(CloudTestContext context)
        {
            _context = context;
        }

        public async Task<List<Cities>> GetAllAsync()
        {
            var cities = await _context.Cities.Select(x => x.City).ToListAsync();

            return await _context.Cities.ToListAsync();
        }
    }
}
