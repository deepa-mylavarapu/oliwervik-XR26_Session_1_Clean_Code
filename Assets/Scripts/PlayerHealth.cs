using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 30f;
    private float currentHealth;

    public event System.Action OnPlayerDefeated;
    public event System.Action<float> OnHealthChanged;

    void Start()
    {
        currentHealth = maxHealth;
        OnHealthChanged?.Invoke(currentHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth = Mathf.Max(currentHealth - amount, 0f);
        OnHealthChanged?.Invoke(currentHealth);
        if (currentHealth <= 0f)
        {
            OnPlayerDefeated?.Invoke();
        }
    }
}
