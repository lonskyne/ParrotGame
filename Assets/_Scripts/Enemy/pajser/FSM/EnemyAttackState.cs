using UnityEngine;

public class EnemyAttackState : EnemyBaseState
{
    float tempAttackTime;

    public override void EnterState(EnemyStateManager enemy){
        enemy.agent.isStopped = true;
        enemy.agent.velocity = Vector3.zero;
        enemy.attackScript.Attack();
        tempAttackTime = enemy.performAttackTime;
    }
    public override void UpdateState(EnemyStateManager enemy){
        if(tempAttackTime > 0){
            tempAttackTime -= Time.deltaTime;
            // Debug.Log("idel:");
        }
        else{
            if(enemy.playerTransform)
                enemy.SwitchState(enemy.ChaseState);
            else
                enemy.SwitchState(enemy.IdleState);
        }   
    }
    public override void OnTriggerEnter(EnemyStateManager enemy){
        
    }
    public override void OnTriggerExit(EnemyStateManager enemy){
        
    }

}
