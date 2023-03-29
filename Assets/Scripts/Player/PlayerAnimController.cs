using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Move move;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private InputManager inputManager;

    private void Update()
    {
        if (inputManager.moveDirection < 0) transform.localScale = new Vector2(-1, 1);
        else if (inputManager.moveDirection > 0) transform.localScale = new Vector2(1, 1); ;
    }

    public void SetState(int state)
    {
        animator.SetInteger("playerState", state);
    }
}
