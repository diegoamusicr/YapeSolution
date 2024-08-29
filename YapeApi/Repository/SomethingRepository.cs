using Microsoft.EntityFrameworkCore;
using YapeApi.Data;
using YapeApi.Model;

namespace YapeApi.Repository
{
    public class SomethingRepository(SomethingContext context) : ISomethingRepository
    {
        private readonly SomethingContext _context = context;

        public async Task<Something> CreateSomethingAsync(Something something)
        {
            await _context.Somethings.AddAsync(something);
            await _context.SaveChangesAsync();
            return something;
        }

        public async Task<IEnumerable<Something>> ListSomethingsAsync()
        {
            return await _context.Somethings.ToListAsync();
        }

        public async Task<Something> GetSomethingAsync(int id)
        {
            return await _context.Somethings.FindAsync(id);
        }

        public async Task UpdateSomethingAsync(Something something)
        {
            _context.Somethings.Update(something);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSomethingAsync(int id)
        {
            var something = new Something()
            {
                Id = id
            };
            _context.Somethings.Remove(something);
            await _context.SaveChangesAsync();
        }
    }
}