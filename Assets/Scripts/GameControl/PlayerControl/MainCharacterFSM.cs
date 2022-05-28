using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainCharacterFSM : AbStatePatternIFSM,AttackAbleTag,PointAbleTag
{
    public override ResponseEvent TriggerEvent(GameEvent gameEvent)
    {
        return null;
    }


    public override ResponseEvent ChangeState(GameEventChangeStateEvent gameEventChangeStateEvent)
    {
        Transistion(gameEventChangeStateEvent.newState);
        return null;
    }

    public ResponseEvent OnBeAttack(AttackEvent attackEvent)
    {
        Transistion(GetComponent<MainCharacterDieState>());
        return  null;
    }

    public ResponseEvent OnGetPoint(PointEvent pointEvent)
    {
        SimpleData.Singleton.CurrentScore++;
        return null;
    }

    
    
}
