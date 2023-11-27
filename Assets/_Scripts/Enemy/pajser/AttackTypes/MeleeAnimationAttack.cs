using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MeleeAnimationAttack : AttackPlayer
{

    [SerializeField] GameObject attackBox;
    [SerializeField] float attackDuration;
    private BoxCollider hitBox;

    // Start is called before the first frame update
    void Start()
    {
        if(!attackBox){
            Debug.Log("attackBox GameObject not attached (Enemy/MeleeAnimationAttack)");
            return;
        }
        else if(!(hitBox = attackBox.GetComponent<BoxCollider>()))
            Debug.Log("missing BoxCollider in" + attackBox.name);
        
        hitBox.enabled = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Attack(){
        StartAttack();
        Invoke("EndAttack", attackDuration);
    }
    
    private void StartAttack(){
        hitBox.enabled = true;
    }

    private void OnTriggerEnter(Collider coll){
        
        if(coll.gameObject.tag == "Player"){
        //Damage player
        Debug.Log("DamagePlayer");
        }

    }

    private void EndAttack(){
        hitBox.enabled = false;
    }
}
