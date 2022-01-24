class OS
{
    public string name { get;set;}
    public string version { get;set;}
    public int ram { get;set;}
    public OS getclone()
    {
        return (OS)this.MemberwiseClone();
    }
}
class program
{
    public static void Main()
    {
        OS oS = new OS();
        oS.name = "Windows";
        oS.version = "Windows 10";
        oS.ram = 8;
        //OS oS1 = oS; //this leads to changes in original object so we need to use MemberwiseClone method
        OS oS1 = oS.getclone();
        oS1.ram = 4;
        System.Console.WriteLine(oS.name + " " + oS.version + " " + oS.ram);
        System.Console.WriteLine(oS1.name + " " + oS1.version + " " + oS1.ram);
    }
}