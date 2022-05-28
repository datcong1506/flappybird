using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PineSpawnerController : MonoBehaviour
{
    public GameObject pinePrefab;
    private ObjectPooling pine_poolling;

    [SerializeField] private float delaySpawnTime = 4f;

    [SerializeField] private float spawnRate;
    public void StartSpawn()
    {
        StartCoroutine(SpawnCorotine());
    }

    private IEnumerator SpawnCorotine()
    {
        pine_poolling = new ObjectPooling(this.gameObject, pinePrefab, 20);
        yield return new WaitForSeconds(delaySpawnTime);
        
        Vector3 lastSpawnPosision=new Vector3(0,-10,0);
        while (true)
        {
            if (Gamemanager.Singleton.MainGameState == GameState.IsPlaying)
            {
                for (int i = 0; i < 30; i++)
                {
                    var newPosision = this.transform.position + UnityEngine.Random.Range(-2, 2) * new Vector3(0, 1, 0);
                    if (math.abs(lastSpawnPosision.y - newPosision.y) >= 1)
                    {
                        pine_poolling.Instantiate(newPosision, Quaternion.identity);
                        lastSpawnPosision = newPosision;
                        goto endLoop;
                    }
                }
                var newPosision1 = this.transform.position + UnityEngine.Random.Range(-2, 2) * new Vector3(0, 1, 0);
                pine_poolling.Instantiate(newPosision1, Quaternion.identity);
                lastSpawnPosision = newPosision1;
                
                
                endLoop:
                yield return new WaitForSeconds(spawnRate);
            }
            else
            {
                break;
            }

        }
    }
}
