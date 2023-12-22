using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerBuffTrigger : MonoBehaviour
{
    private string tagFilter = "Player";
    [SerializeField] private UnityEvent onEnterEvent;
    [SerializeField] private UnityEvent onExitEvent;
    void OnTriggerEnter(Collider collider)
    {
        if (!collider.gameObject.CompareTag(tagFilter))
            return;
        
        onEnterEvent.Invoke();
    }

    void OnTriggerExit(Collider collider) {
        if (!collider.gameObject.CompareTag(tagFilter))
            return;
        
        onExitEvent.Invoke();
    }
}
