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
    [Produces("application/json")]
    public class PropertieGroupsController : ControllerBase
    {
        private readonly IRepository<PropertieGroup> _repo;

        public PropertieGroupsController(IRepository<PropertieGroup> repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Gets the list of saved propertie groups
        /// </summary>
        /// <param name="order">Order By</param>
        /// <param name="pagination">Witch page you are on</param>
        /// <returns>A list of Propertie Groups</returns>
        /// <response code="400">Bad Request</response>   
        [HttpGet]
        public async Task<IActionResult> PropertieGroupsList(
            // [FromQuery] PropertieGroupParams params,
            [FromQuery] Order order,
            [FromQuery] Pagination pagination)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorResponse.FromModelState(ModelState));
            }

            var lista = await _repo
                .All
                .ApplyOrder(order)
                .ToPagedAsync(pagination, "propertieGroups");

            return Ok(lista);
        }

        /// <summary>
        /// Get Propertie Group by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorResponse.FromModelState(ModelState));
            }

            var propertieGroup = await _repo.FindAsync(id);
            if (propertieGroup == null || propertieGroup.Id == 0)
            {
                return NotFound();
            }

            return Ok(propertieGroup);
        }

        /// <summary>
        /// Save a new register
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <response code="400">Bad Request</response>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PropertieGroup model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorResponse.FromModelState(ModelState));
            }
            if (string.IsNullOrEmpty(model.Description))
            {
                return BadRequest(ErrorResponse.FromBadRequest("Description field is mandatory"));
            }
            if (model.Id != 0)
            {
                return BadRequest(ErrorResponse.FromBadRequest("Post method saves a new register.", "You must send Id = 0"));
            }

            await _repo.SaveAsync(model);

            var uri = Url.Action("Get", new { id = model.Id });
            return Created(uri, model);
        }

        /// <summary>
        /// Alter an existent register
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <response code="400">Bad Request</response>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PropertieGroup model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorResponse.FromModelState(ModelState));
            }
            if (string.IsNullOrEmpty(model.Description))
            {
                return BadRequest(ErrorResponse.FromBadRequest("Description field is mandatory"));
            }
            if (model.Id == 0)
            {
                return BadRequest(ErrorResponse.FromBadRequest("No current register", "The Put method alter an existing register, to save a new register, use the Post Method"));
            }

            await _repo.AlterAsync(model);

            return Ok(model);
        }

        /// <summary>
        /// Deletes an existent register
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="204">No Content</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorResponse.FromModelState(ModelState));
            }

            var model = await _repo.FindAsync(id);

            if (model == null || model.Id == 0)
            {
                return NotFound();
            }

            await _repo.DeleteAsync(model);

            return NoContent();
        }
    }
}
