using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public event EventHandler OnJumpPress;

    public float moveDirection;
    [SerializeField] private Move player;
    [SerializeField] private GroundChecker groundChecker;

    void Update()
    {
        float moveDirectionX = Input.GetAxis("Horizontal");

        if (moveDirectionX != 0)
        {
            moveDirection = Input.GetAxisRaw("Horizontal");
            player.MoveAround(moveDirection);
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (groundChecker.Check() == true)
            {
                moveDirection = Input.GetAxisRaw("Vertical");
                OnJumpPress?.Invoke(this, EventArgs.Empty);
            }
            else if(groundChecker.Check() == false) return;
        }
    }
}
