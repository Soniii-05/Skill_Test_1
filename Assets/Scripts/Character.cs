using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public abstract class Character : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    public struct Health
    {
        public int maxHealth;
        public int currentHealth;
        public bool isInvulnerable;

        public void TakeDamage(int amount)
        {
            if (isInvulnerable || currentHealth <= 0)
                return;

            currentHealth -= amount;
            if (currentHealth < 0)
                currentHealth = 0;
        }

        public void Heal(int amount)
        {
            currentHealth += amount;
            if (currentHealth > maxHealth)
                currentHealth = maxHealth;
        }
    }

    public Health health;
}
