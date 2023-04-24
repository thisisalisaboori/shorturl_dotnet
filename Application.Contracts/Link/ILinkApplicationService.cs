using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Contracts.Link
{
    public interface ILinkApplicationService
    {
        Task<LinkDto> GetLink(string link);
        Task<LinkDto> SetLink(CreateLink newLink);
    }
}