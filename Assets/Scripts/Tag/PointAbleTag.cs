using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PointAbleTag
{
    public ResponseEvent OnGetPoint(PointEvent pointEvent);
}

public class PointEvent : GameEvent
{
    
}
