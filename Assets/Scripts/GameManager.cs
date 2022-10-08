using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    private int playerscore;

    public Text playerscoreText;

    private int computerScore;
    public Text computerScoreText;
    public void PlayerScore()
    {
        playerscore++;
        this.playerscoreText.text = playerscore.ToString();
        ResetRound();
    }
    public void ComputerScore()
    {
        computerScore++;
        this.computerScoreText.text = computerScore.ToString();
        ResetRound();
    }
    public void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

}
