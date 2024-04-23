using Tennis.Models;
using Tennis.States;

namespace Tennis.Game;

public class Tennis2Game : ITennisGame
{
    private GameState _gameState;
    private readonly PlayerInfo _player1Info;
    private readonly PlayerInfo _player2Info;

    public Tennis2Game(string player1Name, string player2Name)
    {
        _player1Info = new PlayerInfo(player1Name);
        _player2Info = new PlayerInfo(player2Name);
        _gameState = new EqualityState();
        _gameState.SetContext(this);
    }

    public int GetPlayer1Score() => _player1Info.Score;

    public int GetPlayer2Score() => _player2Info.Score;

    public string GetScore()
    {
        return _gameState.GetScore();
    }

    public void WonPoint(string playerName)
    {
        if (_player1Info.Name == playerName)
        {
            _player1Info.Score++;
        }
        else
        {
            _player2Info.Score++;
        }

        _gameState.ScoreChanged();
    }

    public void TransitionTo(GameState gameState)
    {
        _gameState = gameState;
        _gameState.SetContext(this);
    }
}