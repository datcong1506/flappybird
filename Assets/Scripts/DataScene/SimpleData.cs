using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SimpleData : MonobehaviourSingletonInterface<SimpleData>
{
    private int currentScore;

    private AudioSource _source=>GetComponent<AudioSource>();
    public int CurrentScore
    {
        get
        {
            return currentScore;
        }
        set
        {
            if (value == currentScore + 1)
            {
                _source.PlayOneShot(_source.clip);
            }
            currentScore = value;
            UpdateHighestScore();
        }
    }
    

    private void UpdateHighestScore()
    {
        if (SimpleSecssionScripableObject.Singleton.HighestScore < currentScore)
        {
            SimpleSecssionScripableObject.Singleton.HighestScore = currentScore;
        }   
    }

}
