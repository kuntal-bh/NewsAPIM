using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAPIM.Models
{
    public class NewsRepo
    {
        public string status { get; set; }
        public string totalResults { get; set; }
        public List<Articles> Articles { get; set; }

    }
}
