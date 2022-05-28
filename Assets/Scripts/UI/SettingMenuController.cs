using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SettingMenuController : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TMP_Dropdown colors;
    private void Start()
    {
        _slider.value = SimpleSecssionScripableObject.Singleton.volume;
    }


    public void SetVolume()
    {
        SimpleSecssionScripableObject.Singleton.volume = _slider.value;
    }

    
    public void SetColorCharacter()
    {
        SimpleSecssionScripableObject.Singleton.ChosedIndex = colors.value;
        var anim = GameObject.FindObjectOfType<MainCharacterAnimationController>();
        if (anim != null)
        {
            anim.ChangeColor(colors.value);
        }
    }
}
