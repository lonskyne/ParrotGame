using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Attributes")]
    public float health = 100f;
    public float maxHealth = 100f;

    private PlayerFeedback playerFeedback;

    // private bool isAlive = true;
    // private bool canAttack = true;

    [SerializeField] private PlayerMovement playerMovement;

    private void Start()
    {
        health = maxHealth; 

    }

    private void Update()
    {
        playerMovement.Move();
    }

    public void TakeDamage(float damage)
    {

    }

    private void Die()
    {

    }

    public void Heal(float amount)
    {

    }

}
