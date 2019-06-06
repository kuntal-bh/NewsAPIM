using System.Collections.Generic;
using System.Threading.Tasks;
using NewsAPIM.Models;

namespace NewsAPIM.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<Articles>> GetNews(string url);
    }
}