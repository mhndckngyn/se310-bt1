namespace NongTrai.Animals;

public abstract class Cattle
{
    private int MaxLiterOfMilk { get; set; }
    private string Sound { get; set; }

    protected Cattle(int milk, string sound)
    {
        MaxLiterOfMilk = milk;
        Sound = sound;
    }
    
    public string MakeSound()
    {
        return Sound;
    }
    
    public int ProduceMilk()
    {
        var random = new Random();
        return random.Next(MaxLiterOfMilk + 1);
    }

    public abstract List<Cattle> GiveBirth();
}