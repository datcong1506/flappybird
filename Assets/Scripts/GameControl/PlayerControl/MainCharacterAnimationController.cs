using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MainCharacterAnimationController : AbStatePatternDependencyStateSelf
{
    
    private Animator _animator=>GetComponent<Animator>();


    private void Start()
    {
        ChangeColor(SimpleSecssionScripableObject.Singleton.ChosedIndex);
    }

    public void OnFly()
    {
        _animator.SetTrigger("Fly");
    }

    public override ResponseEvent TriggerEvent(GameEvent gameEvent)
    {

        switch (gameEvent)
        {
            case GameEventChangeStateEvent _gameEventChangeState:
                switch (_gameEventChangeState.newState)
                {
                    case MainCharacterFlyState mainCharacterFlyState:
                        mainCharacterFlyState.onFlyUpEvent.AddListener(OnFly);
                        break;
                    case MainCharacterDieState _:
                        //set animation
                        _animator.SetTrigger("Die");
                        _animator.SetFloat("FlySpeed",0);
                        break;
                }
                break;
        }

        return null;
    }
    
    public void ChangeColor(int index)
    {
        _animator.SetInteger("Index",index);
    }
}
