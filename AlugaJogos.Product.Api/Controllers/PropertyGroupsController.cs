using AlugaJogos.Model;
using AlugaJogos.Persistence;
using AlugaJogos.Product.Api.Extensions;
using AlugaJogos.Product.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AlugaJogos.Product.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    public class PropertyGroupsController : AbstractController<PropertyGroup>
    {
        public PropertyGroupsController(IRepository<PropertyGroup> repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Return a list of saved property groups
        /// </summary>
        /// <param name="description"></param>
        /// <param name="order">Order By</param>
        /// <param name="pagination">Witch page you are on</param>
        /// <returns>A list of Property Groups</returns>
        /// <response code="400">Bad Request</response>   
        [HttpGet]
        public async Task<IActionResult> PropertyGroupsList(
            [FromQuery] string description,
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
                list.Where(g => g.Description.Contains(description));
            }

            await list.ApplyOrder(order)
                .ToPagedAsync(pagination, "propertyGroups");

            return Ok(list);
        }
    }
}
