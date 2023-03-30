using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyCollide : MonoBehaviour
{
    public event EventHandler OnEnemyStomped;

    private Jump jump;
    private PlayerState playerState;
    private Rigidbody2D rb;
    private GameObject player;

    private float knockback = 5f;

    private void Start()
    {
        player = GameObject.Find("Player");
        jump = player.GetComponent<Jump>();
        rb = player.GetComponent<Rigidbody2D>();
        playerState = player.GetComponent<PlayerState>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (playerState.state == PlayerState.State.falling)
            {
                jump.Levioso();
                OnEnemyStomped?.Invoke(this, EventArgs.Empty);
            }
            else if (playerState.state != PlayerState.State.falling)
            {
                playerState.state = PlayerState.State.hurt;
                if (player.transform.position.x < transform.position.x)
                {
                    rb.velocity = new Vector2(-knockback, rb.velocity.y);
                }
                else if (player.transform.position.x > transform.position.x)
                {
                    rb.velocity = new Vector2(knockback, rb.velocity.y);
                }
            }
        }
    }

}
