interface Iaccount
{
    double cash { get; set; }
    void amount();
}
class salary_account : Iaccount
{
    public double cash { get ; set; }

    public void amount()
    {
        Console.WriteLine("I am Salary account with {0}", cash);
    }
}
class savings_account : Iaccount
{
    public double cash { get; set; }

    public void amount()
    {
        Console.WriteLine("I am Savings account with {0}", cash);
    }
}
class program
{
    static void Main()
    {
        salary_account salary_Account = new salary_account();
        savings_account savings_Account = new savings_account();
        salary_Account.amount();
        savings_Account.amount();
    }
}