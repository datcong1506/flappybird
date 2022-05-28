using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        var attackAbleTags =col.gameObject.GetComponents<PointAbleTag>();

        foreach (var attackable in attackAbleTags)
        {
            attackable.OnGetPoint(null);
        }
    }
}
