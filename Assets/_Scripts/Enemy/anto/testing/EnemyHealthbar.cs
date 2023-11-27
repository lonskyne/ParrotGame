using ParrotGame.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ParrotGame.Enemy
{
    public class EnemyHealthbar : MonoBehaviour
    {
        [SerializeField] private EnemyHealth enemyHealth;
        [SerializeField] private Transform fillBar;

        private void Start()
        {
            enemyHealth.OnHit.AddListener(OnHit);
            enemyHealth.OnDeath.AddListener(OnDeath);
        }

        private void OnHit()
        {
            fillBar.localScale = new Vector3(enemyHealth.health, 1f, 1f);
        }

        private void OnDeath()
        {
            fillBar.localScale = Vector3.zero;
        }
    }
}