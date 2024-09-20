using NongTrai.Animals;

namespace NongTrai;

public class Farm
{
    private List<Cattle> Animals { get; } = new();

    public void Init()
    {
        Console.Write("Nhap so luong bo: ");
        do
        {
            var isValid = IntegerValidator.ValidatePositive(Console.ReadLine(), out var numCows);
            if (isValid)
            {
                for (var i = 0; i < numCows; i++)
                {
                    Animals.Add(new Cow());
                }
                break;
            }
            
            Console.WriteLine("So luong khong hop le");
        } while (true);
        
        do
        {
            Console.Write("Nhap so luong cuu: ");
            var isValid = IntegerValidator.ValidatePositive(Console.ReadLine(), out var numSheeps);
            if (isValid)
            {
                for (var i = 0; i < numSheeps; i++)
                {
                    Animals.Add(new Sheep());
                }
                break;
            }
            
            Console.WriteLine("So luong khong hop le");
        } while (true);

        do
        {
            Console.Write("Nhap so luong de: ");
            var isValid = IntegerValidator.ValidatePositive(Console.ReadLine(), out var numGoats);
            if (isValid)
            {
                for (var i = 0; i < numGoats; i++)
                {
                    Animals.Add(new Goat());
                }
                break;
            }
            
            Console.WriteLine("So luong khong hop le! ");
        } while (true);
        
        PrintFarmInfo();
    }

    public void MakeSounds()
    {
        foreach (var animal in Animals)
        {
            var sound = animal.MakeSound();
            Console.WriteLine(sound);
        }
    }

    private void GiveBirth()
    {
        var numberOfParents = Animals.Count;

        for (var i = 0; i < numberOfParents; i++)
        {
            var children = Animals.ElementAt(i).GiveBirth();
            Animals.AddRange(children);
        }
    }

    private int GiveMilk()
    {
        var totalMilk = 0;

        foreach (var animal in Animals)
        {
            totalMilk += animal.ProduceMilk();
        }

        return totalMilk;
    }
    
    public void GiveBirthAndMilk()
    {
        GiveBirth();
        var totalMilk = GiveMilk();
        
        PrintFarmInfo();
        Console.WriteLine($"Tong so sua thu duoc la {totalMilk} lit");
    }

    private void PrintFarmInfo()
    {
        var numCows = Animals.OfType<Cow>().Count();
        var numSheeps = Animals.OfType<Sheep>().Count();
        var numGoats = Animals.OfType<Goat>().Count();
        
        Console.WriteLine($"Bo: {numCows}, Cuu: {numSheeps}, De: {numGoats}");
    }
}