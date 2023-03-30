using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CherryUI : MonoBehaviour
{
    [SerializeField] PlayerValuables player;
    [SerializeField] TextMeshProUGUI cherryText;

    private void Update()
    {
        cherryText.text = player.cherry.ToString();
    }
}
