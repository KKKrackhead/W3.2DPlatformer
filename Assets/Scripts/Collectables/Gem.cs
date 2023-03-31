using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    private AudioSource sound;

    private void Start()
    {
        sound = GameObject.Find("PickUpAudio").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<PlayerValuables>().gem++;
            sound.Play();
            Destroy(gameObject);
        }
    }
}
