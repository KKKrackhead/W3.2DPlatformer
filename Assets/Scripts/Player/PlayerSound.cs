using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] private PlayerState playerState;
    [SerializeField] private AudioSource audioSource;

    bool isWalking = true;

    void Update()
    {
        if (playerState.state == PlayerState.State.walking) isWalking = true;
        else if(playerState.state != PlayerState.State.walking) isWalking = false;

        if (!isWalking) audioSource.Play();
    }
}
