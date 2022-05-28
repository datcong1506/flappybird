using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class GroundAnimationController : MonoBehaviour
{
    private Animator _animator=>GetComponent<Animator>();


    private void Start()
    {
        Gamemanager.Singleton.OnEndSecssionEvent.AddListener(OnEndSecssion);
    }


    private void OnEndSecssion()
    {
        _animator.SetFloat("Movespeed",0);
    }
    
}
