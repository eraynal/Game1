using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private float moveSpeed = 5f;
    private bool attacking;
    private bool moving;

    private Rigidbody2D playerRigidBody;
    private Vector2 playerDirection;
    private Animator playerAnimator;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playerDirection.x = Input.GetAxisRaw("Horizontal");
        playerDirection.y = Input.GetAxisRaw("Vertical");
        attacking = Input.GetKeyDown(KeyCode.Q);
        moving = playerDirection != Vector2.zero;
        UpdateAnimationAndMove();
    }

    void UpdateAnimationAndMove()
    {
        playerAnimator.SetBool("attacking", attacking);
        playerAnimator.SetBool("moving", moving);
        if (moving)
        {
            UpdateAnimation();
            MovePlayer();
        }
    }
    void MovePlayer()
    {
        playerRigidBody.MovePosition(playerRigidBody.position + playerDirection * moveSpeed * Time.fixedDeltaTime);
    }

    void UpdateAnimation()
    {
        playerAnimator.SetFloat("moveX", playerDirection.x);
        playerAnimator.SetFloat("moveY", playerDirection.y);
    }
}