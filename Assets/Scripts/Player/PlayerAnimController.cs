using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Move move;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private InputManager inputManager;

    private void Start()
    {
        animator.SetFloat("walk", Mathf.Abs(rb.velocity.x));
        move.OnWalk += Move_OnWalk;
    }

    private void Move_OnWalk(object sender, System.EventArgs e)
    {
        animator.SetFloat("walk", Mathf.Abs(rb.velocity.x));
    }

    private void Update()
    {
        animator.SetFloat("walk", Mathf.Abs(rb.velocity.x));

        if (inputManager.moveDirection < 0) transform.rotation = Quaternion.Euler(0, 180, 0);
        else if (inputManager.moveDirection > 0) transform.rotation = Quaternion.Euler(0, 0, 0);
    }


}
