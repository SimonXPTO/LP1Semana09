namespace AnimalKingdom
{
public class Bee : Animal, ICanFly
{
    public int NumberOfWings { get; } = 4; // Abelhas têm 4 asas

    public override string Sound()
    {
        return "Zzzzz...";
    }
}
}