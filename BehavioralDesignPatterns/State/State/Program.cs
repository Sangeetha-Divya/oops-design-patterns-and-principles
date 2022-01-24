public interface IVendingMachineState
{
    void SelectProductAndInsertMoney(int amount, String productName);
    void DispenseProduct();
}
public class NoMoneyState : IVendingMachineState
{
    public void DispenseProduct()
    {
        Console.WriteLine("Vending Machine cannot dispense product because money is not inserted and product is not selected");
    }
    public void SelectProductAndInsertMoney(int amount, string productName)
    {
        Console.WriteLine(amount + "Rs has been inserted and " + productName + " has been selected");
    }
}
public class HasMoneyState : IVendingMachineState
{
    public void DispenseProduct()
    {
        Console.WriteLine("Vending Machine  dispensed the product ");
    }
    public void SelectProductAndInsertMoney(int amount, string productName)
    {
        Console.WriteLine("Already Vending machine has money and product selected, So wait till it finish the current dispensing process");
    }
}
public class VendingMachine : IVendingMachineState
{
    public IVendingMachineState vendingMachineState { get; set; }
    public VendingMachine()
    {
        vendingMachineState = new NoMoneyState();
    }

    public void SelectProductAndInsertMoney(int amount, string productName)
    {
        vendingMachineState.SelectProductAndInsertMoney(amount, productName);
        if (vendingMachineState is NoMoneyState)
        {
            vendingMachineState = new HasMoneyState();
            Console.WriteLine("VendingMachine internal state has been moved to : "
                            + vendingMachineState.GetType().Name);
        }
    }
    public void DispenseProduct()
    {
        vendingMachineState.DispenseProduct();
        if (vendingMachineState is HasMoneyState)
        {
            vendingMachineState = new NoMoneyState();
            Console.WriteLine("VendingMachine internal state has been moved to : "
                            + vendingMachineState.GetType().Name);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        VendingMachine vendingMachine = new VendingMachine();
        Console.WriteLine("Current VendingMachine State : "
                        + vendingMachine.vendingMachineState.GetType().Name + "\n");
        vendingMachine.DispenseProduct();
        vendingMachine.SelectProductAndInsertMoney(50, "Pepsi");
        Console.WriteLine("\nCurrent VendingMachine State : "
                        + vendingMachine.vendingMachineState.GetType().Name + "\n");
        vendingMachine.SelectProductAndInsertMoney(50, "Fanta");
        vendingMachine.DispenseProduct();
        Console.WriteLine("\nCurrent VendingMachine State : "
                        + vendingMachine.vendingMachineState.GetType().Name);
        Console.Read();
    }
}