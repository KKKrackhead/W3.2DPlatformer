using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public Vector2 spawnPoint;

    void Start()
    {
        spawnPoint = transform.position;
    }

    public void Respawn()
    {
        transform.position = spawnPoint;
    }
}
