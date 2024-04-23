namespace Tennis.Helpers;

public static class ScoreHelper
{
    public static string GetScoreName(int score)
    {
        switch (score)
        {
            case 0:
                return Constants.Love;
            case 1:
                return Constants.Fifteen;
            case 2:
                return Constants.Thirty;
            case 3:
                return Constants.Forty;
            default: 
                return string.Empty;
        } 
    }

    public static string GetGameScore(int player1Score, int player2Score)
    {
        return $"{GetScoreName(player1Score)}-{GetScoreName(player2Score)}";
    }
}