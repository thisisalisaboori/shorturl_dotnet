using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Contracts.Link
{
    public class LinkDto
    {
        public string Url{get;set;}
        public string ShortUrl{get;set;}
        public long Expired{get;set;}
    }
}