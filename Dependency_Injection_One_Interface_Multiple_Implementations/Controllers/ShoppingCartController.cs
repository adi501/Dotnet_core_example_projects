using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_One_Interface_Multiple_Implementations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCart _shoppingCart;
        public ShoppingCartController(Func<string, IShoppingCart> shoppingCart)
        {
            _shoppingCart= shoppingCart("DB");  // now we are Injected ShoppingCartDB --"DB"
        }
        [HttpGet(Name = "Get")]
        public void Get()
        {
            _shoppingCart.GetCart();  // now it will call ShoppingCartDB class GetCart() method
        }
    }
}
