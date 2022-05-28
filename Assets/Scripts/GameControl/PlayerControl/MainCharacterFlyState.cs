using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class MainCharacterFlyState : AbStatePatternState
{


    private Rigidbody2D _rigidbody2D;
    
    private  Gameinput.PlayerActions playerInput;
    
    public override void OnEnterState()
    {
        game_input_scriableobject.Singleton.Game_input.Player.Enable();
        playerInput = game_input_scriableobject.Singleton.Game_input.Player;

        if (_rigidbody2D == null)
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
    }

    public override void OnUpdateState()
    {
        
    }

    
    public override void OnExitState()
    {
        playerInput.Disable();        
    }

    public override bool DescistionToThisState()
    {
        return false;
    }
    
    public override ResponseEvent TriggerEvent(GameEvent gameEvent)
    {
        return null;
    }


   

    public void Fly()
    {
        if (abStatePatternIFSM.currentState == this)
        {
            _rigidbody2D.velocity=Vector2.zero;
            _rigidbody2D.AddForce(new Vector2(0,4),ForceMode2D.Impulse);
            onFlyUpEvent?.Invoke();
        }
    }

    public UnityEvent onFlyUpEvent;
    /*private void FixedUpdate()
    {
        /*if (abStatePatternIFSM.currentState == this)
        {
            if (tap)
            {
                
            }
        }#1#
    }*/
}
