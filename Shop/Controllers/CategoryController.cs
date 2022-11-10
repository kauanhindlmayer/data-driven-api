using Microsoft.AspNetCore.Mvc;
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
        public string Get()
        {
            return "GET";
        }


        [HttpGet]
        [Route("{id:int}")]
        public string GetById(int id)
        {
            return "GET " + id.ToString();
        }

        [HttpPost]
        [Route("")]
        public Category Post([FromBody]Category model)
        {
            return model;
        }

        [HttpPut]
        [Route("{id:int}")]
        public Category Put(int id, [FromBody]Category model)
        {
            if (model.Id == id)
                return model;

            return null;
        }

        [HttpDelete]
        [Route("")]
        public string Delete()
        {
            return "DELETE";
        }
    }
}
