using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SimpleSecssionScripableObject", menuName = "scriptableObjects/SimpleSecssionScripableObject")]
public class SimpleSecssionScripableObject : ScripableSingletonInterface<SimpleSecssionScripableObject>
{
    [Header("PrefabAsset")]
    public int ChosedIndex;
    
    [Header("HighestScoreInLocalStore")]
    public int HighestScore;

    [Header("GameSettings")] 
    public float volume;
}
