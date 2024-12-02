using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_One_Interface_Multiple_Implementations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCart _shoppingCart;
        public ShoppingCartController(ShoppingCartResolver _ShoppingCartResolver, IShoppingCart shoppingCart)
        {

            _ShoppingCartResolver("DB");
            _shoppingCart = shoppingCart;
        }
        public void Get()
        {
            _shoppingCart.GetCart();
        }
    }
}
