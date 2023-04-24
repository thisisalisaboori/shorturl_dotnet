using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
namespace Infrastructure.Data.Repository
{
    public class LinkRepository
    {
        public async Task<Link> Get(string link){
            return new Link();
        }  

        public async Task<bool> Set(Link link){
            return true;
        } 
    }
}