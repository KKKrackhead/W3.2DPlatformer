using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private InputManager inputManager;

    private void Start()
    {
        inputManager.OnJump += InputManager_OnJump;
    }

    private void InputManager_OnJump(object sender, EventArgs e)
    {
        rb.velocity = new Vector2(rb.velocity.x, 7);
    }
}
