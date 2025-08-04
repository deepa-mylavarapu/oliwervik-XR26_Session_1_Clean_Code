using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Slider healthBar;

    public void UpdateScore(int score)
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    public void UpdateHealth(float health)
    {
        if (healthBar != null)
            healthBar.value = health;
    }

    public void InitializeHealthBar(float maxHealth)
    {
        if (healthBar != null)
        {
            healthBar.maxValue = maxHealth;
            healthBar.value = maxHealth;
        }
    }
}
