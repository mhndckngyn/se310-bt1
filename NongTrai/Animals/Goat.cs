namespace NongTrai.Animals;

public class Goat : Cattle
{
    public Goat() : base(20, "Meh")
    {
    }

    public override List<Cattle> GiveBirth()
    {
        var r = new Random();
        var numOffsprings = r.Next(1, 4);

        var offsprings = new List<Cattle>(numOffsprings);
        for (var i = 0; i < numOffsprings; i++)
        {
            offsprings.Add(new Goat());
        }

        return offsprings;
    }
}