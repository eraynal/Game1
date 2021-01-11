using UnityEngine;

public class EnemyLogMovement : MonoBehaviour
{
    private float enemyLogSpeed = 1f;
    public Transform[] waypoints;

    private Vector3 direction;

    private Transform target;
    private int targetIndex;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        targetIndex = 0;
        target = waypoints[targetIndex];
    }

    void Update()
    {
        direction = (target.position - transform.position).normalized;
        UpdateAnimation();
        transform.Translate(direction * enemyLogSpeed * Time.fixedDeltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            targetIndex = (targetIndex + 1) % waypoints.Length;
            target = waypoints[targetIndex];
        }
    }

    void UpdateAnimation()
    {
        animator.SetFloat("moveX", direction.x);
        animator.SetFloat("moveY", direction.y);
    }
}
