using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ParrotGame.Enemy{
    public class EnemyHealth : MonoBehaviour, IDamagable, IDamagableEvents
    {
        [SerializeField] private float defaultHealth = 100f;

        public float health { get; set; }
        public bool isDead { get; set; }

        public UnityEvent OnHit { get; set; }
        public UnityEvent OnDeath { get; set; }
        

        private void Awake()
        {
            isDead = false;
            health = defaultHealth;

            OnHit = new UnityEvent();
            OnDeath = new UnityEvent(); 
        }

        public void TakeDamage(float damage, Vector3 source)
        {
            if (isDead)
                return;

            health -= damage;
            OnHit.Invoke();

            if(health <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
            // death
            isDead = true;
            OnDeath.Invoke();
        }
    }
}
