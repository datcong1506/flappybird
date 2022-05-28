using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PineController : MonoBehaviour
{
    [SerializeField] private float lifeTime = 10f;

    [SerializeField]private float moveSpeed = 2f;
    
    private void OnEnable()
    {
        StartCoroutine(SetVisible());
    }

    IEnumerator SetVisible()
    {
        yield return new WaitForSeconds(lifeTime);
        if (Gamemanager.Singleton.MainGameState != GameState.PlayerDied)
        {
            gameObject.SetActive(false);
        }
    }
    
    private void Update()
    {
        if (Gamemanager.Singleton.MainGameState == GameState.IsPlaying)
        {
            var newPosision = transform.position;
            newPosision.x += Time.deltaTime * -1 * moveSpeed;
            transform.position = newPosision;
        }
    }
}
