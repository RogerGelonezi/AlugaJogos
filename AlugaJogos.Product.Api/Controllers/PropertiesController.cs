﻿using AlugaJogos.Model;
using AlugaJogos.Persistence;
using AlugaJogos.Product.Api.Extensions;
using AlugaJogos.Product.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AlugaJogos.Product.Api.Controllers
{
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    public class PropertiesController : AbstractController<Property>
    {
        public PropertiesController(IRepository<Property> repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Return a list of properties
        /// </summary>
        /// <param name="description"></param>
        /// <param name="propertyGroupId"></param>
        /// <param name="order"></param>
        /// <param name="pagination"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> PropertiesList(
            [FromQuery] string description,
            [FromQuery] int propertyGroupId,
            [FromQuery] Order order,
            [FromQuery] Pagination pagination)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorResponse.FromModelState(ModelState));
            }

            var list = _repo.All;

            if (!string.IsNullOrEmpty(description))
            {
                list.Where(p => p.Description.Contains(description));
            }
            if (propertyGroupId > 0)
            {
                list.Where(p => p.Group.Id == propertyGroupId);
            }
            
            await list.ApplyOrder(order)
                .ToPagedAsync(pagination, "properties");

            return Ok(list);
        }
    }
}
