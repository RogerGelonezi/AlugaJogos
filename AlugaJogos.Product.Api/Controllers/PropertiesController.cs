using AlugaJogos.Model;
using AlugaJogos.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlugaJogos.Product.Api.Controllers
{
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    public class PropertiesController : ControllerBase
    {
        private readonly IRepository<Propertie> _repo;
        public PropertiesController(IRepository<Propertie> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> PropertiesList()
        {
            if (ModelState.IsValid)
            {
                var list = await _repo.All.ToListAsync();
                return Ok(list);
            }

            return BadRequest();
        }
    }
}
