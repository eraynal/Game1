using UnityEngine;

public class Chest : MonoBehaviour
{

    private bool playerIsInRange;

    private int numberOfCoinsInChest = 10;
    private Animator chestAnimator;

    void Start()
    {
        chestAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (playerIsInRange && Input.GetKeyDown(KeyCode.Q))
        {
            OpenChest();
        }
    }

    private void OpenChest()
    {
        chestAnimator.SetTrigger("openChest");
        Inventory.instance.addCoins(numberOfCoinsInChest);
        playerIsInRange = false;
        GetComponent<Collider2D>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsInRange = false;
        }
    }
}
