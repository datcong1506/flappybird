using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class TouchSimulation : MonoBehaviour
{
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
    }
}
