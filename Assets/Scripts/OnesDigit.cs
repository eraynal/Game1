using UnityEngine;

public class OnesDigit : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetInteger("Value", Inventory.instance.getOnesDigitOfNumberOfCoins());
    }
}
