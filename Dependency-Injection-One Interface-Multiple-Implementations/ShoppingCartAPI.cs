namespace Dependency_Injection_One_Interface_Multiple_Implementations
{
    public class ShoppingCartAPI : IShoppingCart
    {
        public object GetCart()
        {
            return "Cart loaded through API.";
        }
    }
}
