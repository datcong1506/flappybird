using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ScorePanelController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Object;    private void Update()
    {
        m_Object.text = ""+SimpleData.Singleton.CurrentScore;
    }
}
