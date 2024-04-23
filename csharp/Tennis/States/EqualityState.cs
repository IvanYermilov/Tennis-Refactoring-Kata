using Tennis.Helpers;

namespace Tennis.States;

public class EqualityState : GameState
{
    public override string GetScore()
    {
        var player1Score = GameContext.GetPlayer1Score();
        switch (GameContext.GetPlayer1Score())
        {
            case < 3:
                return $"{ScoreHelper.GetScoreName(player1Score)}{Constants.DrawScorePostfix}";
            default:
                return Constants.Deuce;
        }
    }

    public override void ScoreChanged()
    {
        var player1Score = GameContext.GetPlayer1Score();
        var player2Score = GameContext.GetPlayer2Score();

        if (player1Score > player2Score)
        {
            GameContext.TransitionTo(new Player1AheadState());
        }
        else
        {
            GameContext.TransitionTo(new Player2AheadState());
        }
    }
}