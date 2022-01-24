public interface IOrder
{
    void AddToCart();
}

public interface IOnlineOrder
{
    void CCProcess();
}

public class OnlineOrder : IOrder, IOnlineOrder
{
    public void AddToCart()
    {
        Console.WriteLine("ADD to Cart in amazon");
    }

    public void CCProcess()
    {
        Console.WriteLine("Pay through credit card");
    }
}

public class OfflineOrder : IOrder
{
    public void AddToCart()
    {
        Console.WriteLine("ADD to Cart in shopping mail");
    }
   
}
class program
{
    static void Main()
    {
        OnlineOrder onlineOrder = new OnlineOrder();
        OfflineOrder offlineOrder = new OfflineOrder();
        offlineOrder.AddToCart();
        onlineOrder.AddToCart();
        onlineOrder.CCProcess();
    }
}