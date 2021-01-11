using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int maxHealth = 100;
    public int health;

    public HealthBar healthBar;

    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(health);
    }

    public void takeDamages(int damages)
    {
        health = Mathf.Max(0, health - damages);
        healthBar.SetHealth(health);
    }

    public void takeHealing(int healing)
    {
        health = Mathf.Min(maxHealth, health + healing);
        healthBar.SetHealth(health);
    }
}
