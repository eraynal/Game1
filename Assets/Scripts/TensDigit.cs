using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TensDigit : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetInteger("Value", Inventory.instance.getTensDigitOfNumberOfCoins());
    }
}
