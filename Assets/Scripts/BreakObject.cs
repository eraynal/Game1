using UnityEngine;

public class BreakObject : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            getBroken();
        }
    }

    public void getBroken()
    {
        animator.SetBool("broken", true);
    }
}
