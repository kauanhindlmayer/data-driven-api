using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Models;

namespace Shop.Controllers
{
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        // Endpoint => URL
        // https://localhost:5001/categories

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<Category>> Get()
        {
            return new Category();
        }


        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Category>>> GetById(int id)
        {
            return new List<Category>();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Post(
            [FromBody]Category model,
            [FromServices]DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            context.Categories.Add(model);
            await context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Category>>> Put(int id, [FromBody]Category model)
        {
            if (id != model.Id)
                return NotFound(new { message = "Categoria não encontrada" });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(model);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Category>>> Delete()
        {
            return Ok();
        }
    }
}
