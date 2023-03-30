using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FrogAI : MonoBehaviour
{
    public event EventHandler OnFrogJump;
    public event EventHandler OnFrogFall;
    public event EventHandler OnFrogLand;

    [SerializeField] private float leftCap;
    [SerializeField] private float rightCap;
    [SerializeField] private float jumpLength = 5f;
    [SerializeField] private float jumpHeight = 5f;
    [SerializeField] private LayerMask ground;

    private Collider2D coll;
    private Rigidbody2D rb;
    private bool facingLeft = true;
    private Animator anim;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (anim.GetBool("Jumping"))
        {
            if (rb.velocity.y < .1f) OnFrogFall?.Invoke(this, EventArgs.Empty);
        }
        if (anim.GetBool("Falling") && coll.IsTouchingLayers(ground)) OnFrogLand?.Invoke(this, EventArgs.Empty);
    }

    private void Hop()
    {
        if (facingLeft)
        {
            if (transform.position.x > leftCap)
            {
                if (transform.localScale.x != 1) transform.localScale = new Vector3(1, 1);
                if (coll.IsTouchingLayers(ground))
                {
                    rb.velocity = new Vector2(-jumpLength, jumpHeight);
                    OnFrogJump?.Invoke(this, EventArgs.Empty);
                }
            }
            else facingLeft = false;
        }

        else
        {
            if (transform.position.x < rightCap)
            {
                if (transform.localScale.x != -1) transform.localScale = new Vector3(-1, 1);
                if (coll.IsTouchingLayers(ground))
                {
                    rb.velocity = new Vector2(jumpLength, jumpHeight);
                    OnFrogJump?.Invoke(this, EventArgs.Empty);
                }
            }
            else facingLeft = true;
        }
    }
}
