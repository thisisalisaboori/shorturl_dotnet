using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Contracts.Link;
using Application.LinkApplicationService;
namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinkController : ControllerBase
    {
        private readonly ILinkApplicationService _appService;
        public LinkController(ILinkApplicationService appService)
        {
            _appService =appService;
        }

        [HttpGet()]
        public async Task<LinkDto> Get(string link){
           return await _appService.GetLink(link);
        } 

        [HttpPost()]
        public async Task<LinkDto> Get([FromBody] CreateLink js ){
           return await _appService.SetLink(js);
        } 

    }
}