using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemUI : MonoBehaviour
{
    [SerializeField] PlayerValuables player;
    [SerializeField] TextMeshProUGUI gemText;

    private void Update()
    {
        gemText.text = player.gem.ToString();
    }
}
