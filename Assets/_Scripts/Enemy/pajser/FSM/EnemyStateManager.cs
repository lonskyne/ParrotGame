using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStateManager : MonoBehaviour
{

    // references
    public NavMeshAgent agent;
    [HideInInspector] public AttackPlayer attackScript;

    // patroling
    [SerializeField] List<Transform> patrolPointsList;
    Queue<Vector3> patrolPoints = new Queue<Vector3>();


    // state reference
    EnemyBaseState currentState;
    public EnemyPatrolState PatrolState = new EnemyPatrolState();
    public EnemyIdleState IdleState = new EnemyIdleState();
    public EnemyAttackState AttackState = new EnemyAttackState();
    public EnemyChaseState ChaseState = new EnemyChaseState();

    // adsd
    [SerializeField] public float doIdleTime;
    [HideInInspector] public Transform playerTransform;
    [SerializeField] public float performAttackTime;

    



    void Awake(){
        agent = GetComponent<NavMeshAgent>();
        attackScript = GetComponent<AttackPlayer>();
        if(patrolPointsList.Count == 0){
            Debug.LogError("Add at least 1 patrol point to " + this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        foreach(Transform point in patrolPointsList){ // transfer points from list<Transform> to queue<Vector3>
            patrolPoints.Enqueue(point.position);
        }
        

        currentState = IdleState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
        
    }

    public void SwitchState(EnemyBaseState state){
        currentState = state;
        agent.isStopped = false; // this line need to be before EnterState();
        state.EnterState(this);
    }

    public Vector3 GetNextDestination(){
        Vector3 nextDestination = patrolPoints.Dequeue();

        patrolPoints.Enqueue(nextDestination);

        return nextDestination;
    }

    public void GetInfo(Transform T){ // Getting info about who entered/exited trigger box
        
        if(T.gameObject.tag == "Player"){
            playerTransform = T;
            SwitchState(ChaseState);
        }
        

    }

}
