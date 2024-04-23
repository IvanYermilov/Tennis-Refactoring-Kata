using Tennis.Helpers;

namespace Tennis.States;

public class Player1AheadState : GameState
{
    public override string GetScore()
    {
        var player1Score = GameContext.GetPlayer1Score();
        var player2Score = GameContext.GetPlayer2Score();
        
        if (player1Score < 4)
        {
            return ScoreHelper.GetGameScore(player1Score, player2Score);
        }
        if (player1Score - player2Score == 1)
        {
            return Constants.AdvantagePlayer1;
        }

        return Constants.WinPlayer1;
    }

    public override void ScoreChanged()
    {
        var player1Score = GameContext.GetPlayer1Score();
        var player2Score = GameContext.GetPlayer2Score();

        if (player2Score > player1Score)
        {
            GameContext.TransitionTo(new Player2AheadState());
        }
        else if (player1Score == player2Score)
        {
            GameContext.TransitionTo(new EqualityState());
        }
    }
}