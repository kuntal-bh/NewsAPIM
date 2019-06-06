﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAPIM.Models
{
    public class Articles
    {

        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public string publishedAt { get; set; }
        public string content { get; set; }

    }
}
