using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Link
    {
        public string Url { get; set; }
        public string ShortUrl { get; set; }
        public long Expired { get; set; }


        public static Link CreateUrl(string url, string shortUrl,long expied)
        {
            return new Link() { ShortUrl = shortUrl, Url = url, Expired = expied };
        }
    }


}