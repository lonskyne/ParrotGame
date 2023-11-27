using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackPlayer : MonoBehaviour
{
    
    public float range;
    public float repeatCastAfter;
    public GameObject abilityObject;

    public abstract void Attack();

}
