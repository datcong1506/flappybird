using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndSecMenuController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highestScore;
    [SerializeField] TextMeshProUGUI currentScore;


    private void OnEnable()
    {
        highestScore.text = "HighestScore: " + SimpleSecssionScripableObject.Singleton.HighestScore;
        currentScore.text = "CurrentScore: " + SimpleData.Singleton.CurrentScore;
    }
}
