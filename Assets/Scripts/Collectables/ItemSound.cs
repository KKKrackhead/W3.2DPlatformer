using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSound : MonoBehaviour
{
    [SerializeField] private AudioSource sound;

    public void PlaySound()
    {
        sound.Play();
    }
}
