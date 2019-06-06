using System.Collections.Generic;
using System.Threading.Tasks;
using NewsAPIM.Models;

namespace NewsAPIM.Services
{
    public interface IServices
    {
        Task<List<Articles>> GetNewsByCategory();
    }
}