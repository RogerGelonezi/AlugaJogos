using AlugaJogos.Model;
using AlugaJogos.Persistence;
using AlugaJogos.Product.Api.Extensions;
using AlugaJogos.Product.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlugaJogos.Product.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiVersion("1.0")]
    public class PropertieGroupsController : ControllerBase
    {
        private readonly IRepository<PropertieGroup> _repo;

        public PropertieGroupsController(IRepository<PropertieGroup> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> PropertieGroupsList(
            // [FromQuery] PropertieGroupFilter filter,
            [FromQuery] Order order,
            [FromQuery] Pagination pagination)
        {
            if (ModelState.IsValid)
            {
                var lista = await _repo
                    .All
                    .ApplyOrder(order)
                    .ToPagedAsync(pagination, "propertieGroups");
                return Ok(lista);
            }

            return BadRequest();
        }

        // GET api/<PropertieGroupsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PropertieGroupsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PropertieGroup model)
        {
            if (ModelState.IsValid)
            {
                await _repo.SaveAsync(model);
                return Ok(model);
            }

            return BadRequest();
        }

        // PUT api/<PropertieGroupsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PropertieGroupsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
