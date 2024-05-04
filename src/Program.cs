using FacadePattern;

internal class Program
{
    private static void Main(string[] args)
    {
        IUserFacingFacade facade = new UserFacingFacade();
        int cartid = facade.AddToCart(101,4);
        facade.PlaceOrder(cartid, 100001);

    }
}