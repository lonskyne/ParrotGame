using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZvezdaAttack : AttackPlayer
{

    [SerializeField] List<Transform> spawnAbilityPositions;
    [SerializeField] float repeatCastAfter;
    [SerializeField] GameObject abilityObject;
    


    public override void Attack(Transform playerTransform){
        InvokeRepeating("CastAbility", 0, repeatCastAfter);
    }

    private void CastAbility(){
        // Animation
        foreach(Transform point in spawnAbilityPositions){
            Instantiate(abilityObject, point.position, point.rotation);
        }
    }


    


}
