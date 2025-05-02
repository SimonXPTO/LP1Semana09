public class Player
{
    public string Name { get; } // Campo Name, só de leitura
    public int Score { get; set; } // Campo Score, leitura e escrita

    public Player(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public override string ToString()
    {
        return $"Nome: {Name}, Pontuação: {Score}";
    }
}