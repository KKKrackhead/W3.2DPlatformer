using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public event EventHandler OnWalk;

    [SerializeField] private Rigidbody2D rb;
    private float moveSpeed = 6f;

    public void MoveAround(float moveDirection)
    {
        rb.velocity = new Vector2(moveSpeed * moveDirection , rb.velocity.y);
        OnWalk?.Invoke(this, EventArgs.Empty);
    }
}
