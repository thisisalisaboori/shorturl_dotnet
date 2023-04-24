using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
namespace Infrastructure.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Set( Link obj);
        Task<Link> Get(string key);
    }
}