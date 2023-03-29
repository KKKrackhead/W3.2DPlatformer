using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField]private float moveSpeed = 12;

    public void MoveAround(float moveDirection)
    {
        rb.velocity = new Vector2(moveSpeed * moveDirection , rb.velocity.y);
    }
}
