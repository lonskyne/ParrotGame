using UnityEngine;

public class TriggerEnemy : MonoBehaviour
{
    EnemyStateManager stateManager;

    private void Awake()
    {
        stateManager = transform.parent.GetComponent<EnemyStateManager>();
    }

    void OnTriggerEnter(Collider coll)
    {
        stateManager.GetInfo(coll.transform);
    }
    void OnTriggerExit(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
            stateManager.playerTransform = null;

    }
}
