namespace Dependency_Injection_One_Interface_Multiple_Implementations
{
    public interface IShoppingCart
    {
        object GetCart();
    }
    public class ShoppingCartAPI : IShoppingCart
    {
        public object GetCart() 
        {
            return "Cart loaded through API.";
        }
    }
    public class ShoppingCartCache : IShoppingCart
    {
        public object GetCart()
        {
            return "Cart loaded from cache.";
        }
    }
    public class ShoppingCartDB : IShoppingCart
    {
        public object GetCart()
        {
            return "Cart loaded from DB";
        }
    }
}
