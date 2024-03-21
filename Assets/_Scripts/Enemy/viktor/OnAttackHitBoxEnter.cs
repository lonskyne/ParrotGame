using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAttackHitBoxEnter : MonoBehaviour
{
    public bool playerThere = false;

    void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("Player"))
            playerThere = true;
    }

    private void OnTriggerExit(Collider coll)
    {
        if (coll.CompareTag("Player"))
            playerThere = false;
    }
}
