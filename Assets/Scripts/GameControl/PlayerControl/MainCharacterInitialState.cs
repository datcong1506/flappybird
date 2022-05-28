using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class MainCharacterInitialState : AbStatePatternState
{
    private Rigidbody2D _rigidbody2D;
    public override void OnEnterState()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    public override void OnUpdateState()
    {
        
    }

    public override void OnExitState()
    {
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    public override bool DescistionToThisState()
    {
        return  false;
    }

    public override ResponseEvent TriggerEvent(GameEvent gameEvent)
    {
        return null;
    }
}
