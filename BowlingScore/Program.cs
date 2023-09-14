public class Game
{
    public int CurrentFrame { get; set; }
    public int CurrentRole { get; set; }
    public List<int> Rolls { get; set; }
    public List<int> FrameScores { get; set; }

    public Game() 
    {
        CurrentFrame = 1;
        CurrentRole = 1;
        Rolls = new List<int>();
        FrameScores = new List<int>();
    }

    public void Roll(int pins)
    {
        Rolls.Add(pins);

        if (pins == 10)
        {
            CurrentFrame++;
            int strikeBonus = 0;

            if (Rolls.Count >= (CurrentRole + 2))
            {
                strikeBonus = Rolls[CurrentRole] + Rolls[CurrentRole + 1];
            }
            else if (Rolls.Count == (CurrentRole + 1))
            {
                strikeBonus = Rolls[CurrentRole];
            }

            FrameScores.Add(10 + strikeBonus);
        }
    }
}