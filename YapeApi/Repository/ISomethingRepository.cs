using YapeApi.Model;

namespace YapeApi.Repository
{
    public interface ISomethingRepository
    {
        Task<Something> CreateSomethingAsync(Something something);
        Task<IEnumerable<Something>> ListSomethingsAsync();
        Task<Something> GetSomethingAsync(int id);
        Task UpdateSomethingAsync(Something something);
        Task DeleteSomethingAsync(int id);
    }
}