using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Contracts.Link;
using Infrastructure.Data;
using Domain;
using Infrastructure.Util;
namespace Application.LinkApplicationService
{
    public class LinkApplicationService: ILinkApplicationService
    {
        private readonly IUnitOfWork _unitofwork;
        public LinkApplicationService(IUnitOfWork unitOfWork)
        {
            _unitofwork = unitOfWork;
        }

        public async Task<LinkDto> GetLink(string link){
            var res = await _unitofwork.Get(link);
            return new LinkDto() { ShortUrl = res.ShortUrl , Url =res.Url};
        }
        public async Task<LinkDto> SetLink(CreateLink newLink){
            Link newObj = Link.CreateUrl(newLink.Link , newLink.Link.MakeHashLink(),0);
            var res = await _unitofwork.Set(newObj);
            return new LinkDto() {ShortUrl = newObj.ShortUrl , Url =newObj.Url };
        }
    }
}