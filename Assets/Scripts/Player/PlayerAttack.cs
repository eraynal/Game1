using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private bool attacking;

    void Start()
    {
        
    }

    void Update()
    {
        attacking = Input.GetKeyDown(KeyCode.Q);
        if (attacking)
        {
            GetComponent<Collider2D>().enabled = true;
        } else
        {
            GetComponent<Collider2D>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Breakable"))
        {
            Debug.Log(collision.name);
            BreakObject breakObject = collision.transform.GetComponent<BreakObject>();
            breakObject.getBroken();
        }
    }
}
