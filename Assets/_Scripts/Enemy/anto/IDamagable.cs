using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ParrotGame.Enemy
{
    public interface IDamagable
    {
        public float health { get; set; }
        public bool isDead { get; set; }

        public void TakeDamage(float damage, Vector3 source);
        public void Die();
    }
}