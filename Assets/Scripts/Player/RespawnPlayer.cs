using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    [SerializeField] RespawnPoint respawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        respawn.Respawn();
    }
}
