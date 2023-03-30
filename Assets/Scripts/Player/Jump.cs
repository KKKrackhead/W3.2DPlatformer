using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float jumpForce = 5;

    private void Start()
    {
        inputManager.OnJumpPress += InputManager_OnJumpPress;
    }

    private void InputManager_OnJumpPress(object sender, EventArgs e)
    {
        Levioso();
    }

    public void Levioso()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
