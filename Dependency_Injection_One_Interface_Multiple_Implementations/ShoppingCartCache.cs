namespace Dependency_Injection_One_Interface_Multiple_Implementations
{
    public class ShoppingCartCache : IShoppingCart
    {
        public object GetCart()
        {
            return "Cart loaded from cache.";
        }
    }
}
