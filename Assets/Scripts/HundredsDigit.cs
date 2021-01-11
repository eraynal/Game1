using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HundredsDigit : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetInteger("Value", Inventory.instance.getHundredsDigitOfNumberOfCoins());
    }
}
