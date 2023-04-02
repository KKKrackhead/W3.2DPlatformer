using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemBase : MonoBehaviour
{
    public event EventHandler OnPickUp;

    protected ItemSound sound;

    protected virtual void Start()
    {
        sound = GameObject.Find("PickUpAudio").GetComponent<ItemSound>();
    }

    protected void PickUp()
    {
        OnPickUp?.Invoke(this, EventArgs.Empty);
    }

    protected void ItemAudio()
    {
        sound.PlaySound();
    }

    
}
