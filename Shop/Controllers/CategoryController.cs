using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    // Endpoint => URL
    // https://localhost:5001/categories

    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        // https://localhost:5001/categories
        [Route("")]
        public string MeuMetodo()
        {
            return "Olá, Mundo!";
        }
    }
}
