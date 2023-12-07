using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDealDmg : MonoBehaviour
{
    [SerializeField] float damage;

    void OnTriggerEnter(Collider coll){
        var dmgThis = coll.GetComponent<IDamagable>();
        if(dmgThis != null){
            dmgThis.TakeDamage(damage, this.transform);
        }
   }

}
