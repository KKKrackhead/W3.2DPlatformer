using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private LayerMask ground;
    [SerializeField] private Collider2D playerCollider;

    public bool Check()
    {
        if (playerCollider.IsTouchingLayers(ground)) return true;
        else return false;
    }
}
