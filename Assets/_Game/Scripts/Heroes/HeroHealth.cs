using System;
using UnityEngine;
using NusantaraMOBA.Core;

namespace NusantaraMOBA.Heroes
{
    [DisallowMultipleComponent]
    public sealed class HeroHealth : MonoBehaviour, IDamageable
    {
        [SerializeField, Min(1f)] private float maxHealth = 500f;
        [SerializeField] private bool destroyOnDefeat;

        public float MaxHealth => maxHealth;
        public float CurrentHealth { get; private set; }
        public bool IsAlive => CurrentHealth > 0f;

        public event Action<float, float> HealthChanged;
        public event Action Defeated;

        private void Awake()
        {
            maxHealth = Mathf.Max(1f, maxHealth);
            CurrentHealth = maxHealth;
            HealthChanged?.Invoke(CurrentHealth, maxHealth);
        }

        public void TakeDamage(float amount)
        {
            if (!IsAlive || amount <= 0f || float.IsNaN(amount) || float.IsInfinity(amount))
                return;

            CurrentHealth = Mathf.Max(0f, CurrentHealth - amount);
            HealthChanged?.Invoke(CurrentHealth, maxHealth);
            if (CurrentHealth <= 0f)
            {
                Defeated?.Invoke();
                if (destroyOnDefeat) Destroy(gameObject);
            }
        }

        public void Heal(float amount)
        {
            if (!IsAlive || amount <= 0f || float.IsNaN(amount) || float.IsInfinity(amount))
                return;

            CurrentHealth = Mathf.Min(maxHealth, CurrentHealth + amount);
            HealthChanged?.Invoke(CurrentHealth, maxHealth);
        }

        public void ResetHealth()
        {
            CurrentHealth = maxHealth;
            HealthChanged?.Invoke(CurrentHealth, maxHealth);
        }
    }
}
