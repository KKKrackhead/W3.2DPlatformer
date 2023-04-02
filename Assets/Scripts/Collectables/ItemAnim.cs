using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAnim : MonoBehaviour
{
    private ItemBase itemBase;

    private void Start()
    {
        itemBase = GetComponent<ItemBase>();
        itemBase.OnPickUp += ItemBase_OnPickUp;
    }

    private void ItemBase_OnPickUp(object sender, System.EventArgs e)
    {
        GetComponent<Animator>().SetTrigger("PickedUp");
    }

    public void ByeBye()
    {
        Destroy(gameObject);
    }
}
