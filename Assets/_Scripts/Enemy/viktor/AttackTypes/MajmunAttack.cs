using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class MajmunAttack : AttackPlayer { 

    public Transform player;
    [SerializeField] List<Transform> spawnAbilityPositions;

    [SerializeField] BoxCollider weaponTrigger;
    [SerializeField] OnAttackHitBoxEnter attackHitboxScr;
    [SerializeField] private float maxAttackSpeed = 23f;

    [SerializeField] GameObject abilityObject1;
    [SerializeField] GameObject abilityObject2;

    private float startSpeed;
    int attackType;
    Vector3 prevHorizDirection;
    Vector3 horizontalDirection;
    Vector3 directionToPlayer;
    Vector3 playerStartPos;


    // Start is called before the first frame update
    void Start()
    {
        attackFinished = true;
        startSpeed = agent.speed;
        attackType = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!attackFinished)
        {
            Vector3 directionToPlayer = playerStartPos - transform.position;
            Vector3 horizontalDirection = new Vector3(directionToPlayer.x, 0f, directionToPlayer.z);



            // Gadjamo kokosom
            if(attackType == 0 && attackHitboxScr.playerThere)
            {
                Invoke("KokosThrow", 0);

                attackType = 0;
                attackFinished = true;
                agent.isStopped = false;
            }
            else if (attackType == 1)
            {

            }

            
        }
    }

    public override void Attack(Transform playerTransform)
    {
        attackFinished = false;
        playerStartPos = playerTransform.position;
        Vector3 directionOfAttack = (playerTransform.position - transform.position);
        weaponTrigger.enabled = true;

        prevHorizDirection = new Vector3(100, 100, 100);
        player = playerTransform;
        agent.isStopped = true;
    }

    private void KokosThrow()
    {
        foreach (Transform point in spawnAbilityPositions)
        {
            Instantiate(abilityObject1, point.position, point.rotation);
        }
    }
}
