using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        var attackAbleTags =other.gameObject.GetComponents<AttackAbleTag>();

        foreach (var attackable in attackAbleTags)
        {
            attackable.OnBeAttack(null);
        }
    }
}
