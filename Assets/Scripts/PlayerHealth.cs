using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public delegate void HealthChanged(float currentHealth);
    public event HealthChanged OnHealthChanged;

    public delegate void PlayerDefeated();
    public event PlayerDefeated OnDefeated;

    [SerializeField] private float maxHealth = 100f;
    private float currentHealth;

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
            OnDefeated?.Invoke();
        }
    }
}

