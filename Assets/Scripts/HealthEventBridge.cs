using UnityEngine;

public class HealthEventBridge : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;

    void Start()
    {
        if (playerHealth != null)
        {
            playerHealth.OnDefeated += HandleGameOver;
        }
        else
        {
            Debug.LogWarning("PlayerHealth reference missing!");
        }
    }

    void HandleGameOver()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.GameOver();
        }
        else
        {
            Debug.LogError("GameManager Singleton not found!");
        }
    }
}
