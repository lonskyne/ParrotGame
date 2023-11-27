using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ParrotGame.Enemy
{
    public interface IDamagableEvents
    {
        public UnityEvent OnHit { get; set; }
        public UnityEvent OnDeath { get; set; } 
    }
}