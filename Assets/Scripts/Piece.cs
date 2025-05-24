using Unity.VisualScripting;
using UnityEngine;

public class Piece
{
    private float maxHealth = 20f;
    private float health;
    private float baseDamage = 5f;

    public Piece(float initialHealth)
    {
        health = Mathf.Clamp(initialHealth, 0, maxHealth);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    public void Heal(float amount)
    {
        health += amount;
    }

    public float GetHealthFactor()
    {
        return health;
    }

    public bool IsDestroyed()
    {
        return health <= 0;
    }

    public float GetDamage()
    {
        return baseDamage;
    }

    public void IncreaseDamage(float amount)
    {
        baseDamage += amount;
    }
}

