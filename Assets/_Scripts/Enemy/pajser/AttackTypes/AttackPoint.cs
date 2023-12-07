using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPoint : AttackPlayer
{
    [SerializeField] Vector3 pointOfDamage;
    [SerializeField] float damageRadius;
    [SerializeField] float attackDelay;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack(Transform playerTransform){
        Invoke("TriggerSpherePointAttack", attackDelay);
    }

    private void TriggerSpherePointAttack(){
        Collider[] hitColliders = Physics.OverlapSphere(pointOfDamage, damageRadius);
        foreach (var hitCollider in hitColliders)
        {
            if(hitCollider.gameObject.tag == "Player")
                //DamagePlayer
                Debug.Log(hitCollider.gameObject.name);
        }
    }
}
