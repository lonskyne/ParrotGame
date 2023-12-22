using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuffWizard : MonoBehaviour
{
    public GameObject player;
    private PlayerMovement moveScript;

    private float defaultWalkSpeed;
    private float defaultSprintSpeed;
    void Start()
    {
        moveScript = player.GetComponent<PlayerMovement>();

        defaultWalkSpeed = moveScript.walkSpeed;
        defaultSprintSpeed = moveScript.sprintSpeed;
    }
    public void playerSpeedChange(int speedPercent)
    {
        moveScript.moveSpeed = moveScript.moveSpeed / 100 * speedPercent;
        moveScript.walkSpeed = defaultWalkSpeed / 100 * speedPercent;
        moveScript.sprintSpeed = defaultSprintSpeed / 100 * speedPercent;
    }

    public void playerSpeedRestore()
    {
        moveScript.moveSpeed = defaultWalkSpeed;
        moveScript.walkSpeed = defaultWalkSpeed;
        moveScript.sprintSpeed = defaultSprintSpeed;
    }
}
