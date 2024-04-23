using Tennis.Game;

namespace Tennis.States;

public abstract class GameState
{
    protected Tennis2Game GameContext;

    public void SetContext(Tennis2Game gameContext)
    {
        GameContext = gameContext;
    }
    
    public abstract string GetScore();
    
    public abstract void ScoreChanged();
}