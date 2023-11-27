using UnityEngine;

public class EnemyIdleState : EnemyBaseState
{
    
    float tempIdleTime;

    public override void EnterState(EnemyStateManager enemy){
        enemy.agent.isStopped = true;
        tempIdleTime = enemy.doIdleTime;
        // do idle animation
    }
    public override void UpdateState(EnemyStateManager enemy){

        if(tempIdleTime > 0){
            tempIdleTime -= Time.deltaTime;
            // Debug.Log("idel:");
        }
        else{
            enemy.SwitchState(enemy.PatrolState);
        }
    }
    public override void OnTriggerEnter(EnemyStateManager enemy){
        
    }
    
    public override void OnTriggerExit(EnemyStateManager enemy){
        
    }
}
