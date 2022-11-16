using Microsoft.AspNetCore.Mvc;
using MISA.AMIS.Common.Entities;
using MISA.AMIS.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.AMIS.KeToan.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController<MISAEnity> : ControllerBase
    {
        IBaseService<MISAEnity> _baseService;
        public BaseController(IBaseService<MISAEnity> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public IEnumerable<MISAEnity> Get()
        {
            return _baseService.Get();
        }

        [HttpPost]
        public IActionResult Insert(MISAEnity enity)
        {
            var serviceResult = _baseService.Insert(enity);
            return Ok(serviceResult);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, MISAEnity enity)
        {
            var serviceResult = _baseService.Update(id, enity);
            return Ok(serviceResult);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string Id)
        {   
            return Ok(_baseService.Delete(Id));
        }
    }
}
