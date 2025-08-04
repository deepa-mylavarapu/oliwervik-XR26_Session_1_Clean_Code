using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int score = 0;

    public event System.Action<int> OnScoreChanged;

    public void AddScore(int amount)
    {
        score += amount;
        OnScoreChanged?.Invoke(score);
    }

    public int GetScore() => score;
}
