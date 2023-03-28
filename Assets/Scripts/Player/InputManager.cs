using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public event EventHandler OnJump;

    public float moveDirection;
    [SerializeField] private Move player;

    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            moveDirection = Input.GetAxisRaw("Horizontal");
            player.MoveAround(moveDirection);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJump?.Invoke(this, EventArgs.Empty);
        }
    }
}
