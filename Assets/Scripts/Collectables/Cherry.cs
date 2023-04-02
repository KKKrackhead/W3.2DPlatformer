using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cherry : ItemBase
{
    

    protected override void Start()
    {
        base.Start();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<PlayerValuables>().cherry++;
            ItemAudio();
            PickUp();
        }
    }
}
