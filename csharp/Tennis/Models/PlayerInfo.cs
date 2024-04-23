namespace Tennis.Models;

public class PlayerInfo(string name, int score = 0)
{
    public string Name = name;

    public int Score = score;
}