//encapsulation = data hiding + abstraction
// secure
//tightly encapsulated if and only if every variable of that class declared as private
using System;
class details
{
    private int phone_number;
    private string college_name;
    public int PhoneNumber { get; set; }
    public string college_Name { get { return college_name; } set { college_name = value; } }

}
class encapsulation
{
    public static void Main()
    {
        details Details = new details();
        Details.college_Name = "Tirumala Engineering College";
        Details.PhoneNumber = 123456789;
        Console.WriteLine(Details.college_Name);
    }
}