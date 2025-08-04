using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public bool IsGameOver { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // Prevent duplicates
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); // Optional: persist across scenes
    }

    public void GameOver()
    {
        if (IsGameOver) return;

        IsGameOver = true;
        Debug.Log("Game Over triggered!");
        // Trigger UI update or scene transition
    }

    public void WinGame()
    {
        if (IsGameOver) return;

        IsGameOver = true;
        Debug.Log("Player Wins!");
        // Trigger win screen or animation
    }
}

