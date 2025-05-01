namespace AnimalKingdom
{
public class Bat : Animal, IMammal, ICanFly
{
    public int NumberOfNipples { get; } = 2; // Morcegos geralmente têm 2 mamilos
    public int NumberOfWings { get; } = 2; // Morcegos têm 2 asas

    public override string Sound()
    {
        return "Chiado!";
    }
}
}