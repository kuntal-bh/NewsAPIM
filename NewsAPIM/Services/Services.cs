using Microsoft.Extensions.Configuration;
using NewsAPIM.Models;
using NewsAPIM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAPIM.Services
{
    public class Services : IServices
    {
        private readonly IConfiguration _configuration;
        private readonly IRepository _repository;

        public Services(IConfiguration configuration, IRepository repository)
        {
            _configuration = configuration;
            _repository = repository;
        }

        public async Task<List<Articles>> GetNewsByCategory()
        {

            string baseUrl = _configuration.GetSection("NewsAPI:baseUrl").Value;
            string key = _configuration.GetSection("NewsAPI:key").Value;
            string url = baseUrl + "/everything?q=insurance&apikey=" + key + "&language=en&page=1";
            var newsArticles = await _repository.GetNews(url);

            if (newsArticles != null)
                return newsArticles.ToList();

            throw new Exception("News Articles not found");
        }

    }
}
