namespace Dependency_Injection_One_Interface_Multiple_Implementations
{
    public class ShoppingCartDB : IShoppingCart
    {
        public object GetCart()
        {
            return "Cart loaded from DB";
        }
    }
}
