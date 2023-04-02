using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject miscCamera1;
    [SerializeField] private GameObject miscCamera2;
    [SerializeField] private BoxCollider2D player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            mainCamera.SetActive(true);
            miscCamera1.SetActive(false);
            miscCamera2.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == player)
        {
            mainCamera.SetActive(false);
        }
    }
}
