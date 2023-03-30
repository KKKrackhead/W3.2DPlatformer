using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private PlayerAnimController animControl;
    [SerializeField] private GroundChecker groundChecker;

    public enum State { idle, walking, jumping, falling, hurt }
    public State state = State.idle;

    private void Start()
    {
        inputManager.OnJumpPress += InputManager_OnJumpPress;
    }

    private void InputManager_OnJumpPress(object sender, System.EventArgs e)
    {
        state = State.jumping;
    }

    void Update()
    {
        if (state == State.jumping)
        {
            if (rb.velocity.y < .1f) state = State.falling;
            if (rb.velocity.y == 0) state = State.idle;
        }
        else if (state == State.falling)
        {
            if (groundChecker.Check() == true) state = State.idle;
        }
        else if (state == State.hurt)
        {
            if (Mathf.Abs(rb.velocity.x) < .1f) state = State.idle;
        }
        else if (Mathf.Abs(rb.velocity.x) > 2f) state = State.walking;
        else state = State.idle;

        animControl.SetState((int)state);
    }
}
