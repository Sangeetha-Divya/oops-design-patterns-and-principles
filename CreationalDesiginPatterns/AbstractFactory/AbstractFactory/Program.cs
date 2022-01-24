interface IMobilePhone
{
    ISmartPhone GetSmartPhone();
    INormalPhone GetNormalPhone();
}
interface ISmartPhone
{
    string GetModelDetails();
}
interface INormalPhone
{
    string GetModelDetails();
}
class Nokia : IMobilePhone
{
    public ISmartPhone GetSmartPhone()
    {
        return new NokiaPixel();
    }

    public INormalPhone GetNormalPhone()
    {
        return new Nokia1600();
    }
}
class Samsung : IMobilePhone
{
    public ISmartPhone GetSmartPhone()
    {
        return new SamsungGalaxy();
    }

    public INormalPhone GetNormalPhone()
    {
        return new SamsungGuru();
    }
}
class NokiaPixel : ISmartPhone
{
    public string GetModelDetails()
    {
        return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
    }
}
class SamsungGalaxy : ISmartPhone
{
    public string GetModelDetails()
    {
        return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
    }
}
class Nokia1600 : INormalPhone
{
    public string GetModelDetails()
    {
        return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
    }
}
class SamsungGuru : INormalPhone
{
    public string GetModelDetails()
    {
        return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
    }
}
class MobileClient
{
    ISmartPhone smartPhone;
    INormalPhone normalPhone;

    public Client(IMobilePhone factory)
    {
        smartPhone = factory.GetSmartPhone();
        normalPhone = factory.GetNormalPhone();
    }

    public string GetSmartPhoneModelDetails()
    {
        return smartPhone.GetModelDetails();
    }

    public string GetNormalPhoneModelDetails()
    {
        return normalPhone.GetModelDetails();
    }
}
class Program
{
    static void Main()
    {
        IMobilePhone nokiaMobilePhone = new Nokia();
        MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);
        Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
        Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

        IMobilePhone samsungMobilePhone = new Samsung();
        MobileClient samsungClient = new MobileClient(samsungMobilePhone);
        Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
        Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());
    }
}