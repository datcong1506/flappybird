using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AttackAbleTag
{
    public ResponseEvent OnBeAttack(AttackEvent attackEvent);
}

public class AttackEvent : GameEvent
{
    
}
