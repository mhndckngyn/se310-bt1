namespace NongTrai.Animals;

public class Sheep : Cattle
{
    public Sheep() : base(5, "Baa")
    {
    }

    public override List<Cattle> GiveBirth()
    {
        var r = new Random();
        var numOffsprings = r.Next(1, 4);

        var offsprings = new List<Cattle>(numOffsprings);
        for (var i = 0; i < numOffsprings; i++)
        {
            offsprings.Add(new Sheep());
        }

        return offsprings;
    }
}