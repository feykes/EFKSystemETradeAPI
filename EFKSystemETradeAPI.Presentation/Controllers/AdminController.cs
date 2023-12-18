using EFKSystemETradeAPI.Application.Repositories;
using EFKSystemETradeAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFKSystemETradeAPI.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
       private readonly IProvinceWriteRepository _provinceWriteRepository;

        public AdminController(IProvinceWriteRepository provinceWriteRepository)
        {
            _provinceWriteRepository = provinceWriteRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(List<Province> provinces)
        {
            return Ok();
        }
    }
}

   
