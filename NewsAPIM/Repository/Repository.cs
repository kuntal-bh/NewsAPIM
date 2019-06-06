using NewsAPIM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewsAPIM.Repository
{
    public class Repository : IRepository
    {
        public async Task<IEnumerable<Articles>> GetNews(string url)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept
               .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var data = await responseMessage.Content.ReadAsStringAsync();

                var news = JsonConvert.DeserializeObject<NewsRepo>(data);

                var transformedNews = news.Articles.Take(6).ToList();

                return transformedNews;
            }

            return null;

        }

    }
}
