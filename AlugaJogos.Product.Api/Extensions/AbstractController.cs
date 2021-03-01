using AlugaJogos.Persistence;
using AlugaJogos.Product.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AlugaJogos.Product.Api.Extensions
{
    public abstract class AbstractController<TEntity> : ControllerBase where TEntity : class
    {
        public IRepository<TEntity> _repo;

        /// <summary>
        /// Get model by Id
        /// </summary>
        /// <param name="id"></param>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorResponse.FromModelState(ModelState));
            }

            var model = await _repo.FindAsync(id);
            
            return Ok(model);
        }

        
        /// <summary>
        /// Save a new register
        /// </summary>
        /// <param name="model"></param>
        /// <response code="400">Bad Request</response>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TEntity model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorResponse.FromModelState(ModelState));
            }

            await _repo.SaveAsync(model);

            return Ok(model);
        }

        /// <summary>
        /// Alter an existent register
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <response code="400">Bad Request</response>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TEntity model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorResponse.FromModelState(ModelState));
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

            if (model == null)
            {
                return NotFound();
            }

            await _repo.DeleteAsync(model);

            return NoContent();
        }
    }
}
