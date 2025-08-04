using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameStatusText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private PlayerScore playerScore;

    private bool gameOver = false;

    void Start()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        gameStatusText.text = "Game Started!";
        playerScore.OnScoreChanged += CheckWinCondition;
    }

    private void CheckWinCondition(int score)
    {
        if (!gameOver && score >= 30)
        {
            WinGame();
        }
    }

    public void GameOver()
    {
        if (!gameOver)
        {
            gameOver = true;
            gameStatusText.text = "GAME OVER!";
            gameOverPanel.SetActive(true);
            Invoke(nameof(RestartGame), 2f);
        }
    }

    public void WinGame()
    {
        gameOver = true;
        gameStatusText.text = "YOU WIN!";
        Invoke(nameof(RestartGame), 2f);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
