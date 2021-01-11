using UnityEngine;

public class EnemyLogAttack : MonoBehaviour
{
    private int attackPower = 10;

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.takeDamages(attackPower);
        }
    }
}
