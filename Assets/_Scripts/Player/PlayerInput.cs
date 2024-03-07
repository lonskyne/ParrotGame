using UnityEngine;

public class PlayerInput : MonoBehaviour {

    private Player playerScript;

    private int curAbility = -1;
    private int curConnector = -1;
    private int curAbility2 = -1;

    private float aTimer = 0f;
    private const float timerWait = 1f;
    private bool timerActive = false;

    void Awake(){
        playerScript = GetComponent<Player>();
    }

    
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)){
            playerScript.FireAbility();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
            processAbilityInput(1);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            processAbilityInput(2);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            processAbilityInput(3);

        if (Input.GetKeyDown(KeyCode.Alpha4))
            processAbilityInput(4);

        if (timerActive)
        {
            aTimer -= Time.deltaTime;

            if (aTimer <= 0.0f)
            {
                timerEnded();
                timerActive = false;
            }

            if (Input.GetKeyDown(KeyCode.Q))
                processConnectorInput(1);

            if (Input.GetKeyDown(KeyCode.E))
                processConnectorInput(2);
        }
    }

    private void processAbilityInput(int inputValue)
    {
        if (curAbility == -1 && curConnector == -1 && curAbility2 == -1)
        {
            curAbility = inputValue;
            aTimer = timerWait;
            timerActive = true;
        }

        if (curAbility > -1 && curConnector > -1 && curAbility2 == -1)
        {
            curAbility2 = inputValue;
            aTimer = 0.0f;
        }
    }

    private void processConnectorInput(int inputValue)
    {
        if(curAbility > -1 && curAbility2 == -1 && curConnector == -1)
        {
            curConnector = inputValue;
            aTimer = timerWait;
            timerActive = true;
        }
    }

    private void timerEnded()
    {
        Debug.Log(curAbility + " " + curConnector + " " + curAbility2);

        curAbility = -1;
        curAbility2 = -1;
        curConnector = -1;
    }

    public Vector2 GetMovementVectorNormalized(){

        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W)){
            inputVector.y = +1;  
        } if (Input.GetKey(KeyCode.S)) {
            inputVector.y = -1;
        } if (Input.GetKey(KeyCode.A)) {
            inputVector.x = -1;
        } if (Input.GetKey(KeyCode.D)) {
            inputVector.x = +1;
        }

        inputVector = inputVector.normalized;
        return inputVector;
    }

}