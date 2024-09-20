namespace NongTrai;

class Program
{
    private static void Main(string[] args)
    {
        var farm = new Farm();
        
        farm.Init();
        Console.WriteLine("------------");
        farm.MakeSounds();
        Console.WriteLine("------------");
        farm.GiveBirthAndMilk();
    }
}