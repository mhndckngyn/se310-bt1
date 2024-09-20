namespace NongTrai.Animals;

public class Cow : Cattle
{
    public Cow() : base(20, "Moo")
    {
    }

    public override List<Cattle> GiveBirth()
    {
        var r = new Random();
        var numOffsprings = r.Next(1, 3);

        var offsprings = new List<Cattle>(numOffsprings);
        for (var i = 0; i < numOffsprings; i++)
        {
            offsprings.Add(new Cow());
        }

        return offsprings;
    }
}