using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingAbility : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float abilitySpeed;
    [SerializeField] float destroyAfter;
    [SerializeField] float acceleration;

    // Start is called before the first frame update
    void Start()
    {
        if(!(rb = gameObject.GetComponent<Rigidbody>())){
            Debug.Log("add Rigidbody to" + this);
            return;
        }
        
        rb.velocity = transform.forward * abilitySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(acceleration != 0)
            rb.velocity += transform.forward * acceleration/100f;
        
        Invoke("DestroySelf", destroyAfter);
    }

    public void OnTriggerEnter(Collider coll){
        if(coll.tag == "Player")
            DestroySelf();
    }

    private void DestroySelf(){
        Destroy(this.gameObject);
    }
}
