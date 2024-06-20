using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject enemy;

    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);
        if(enableSpawn )
        {
            GameObject go = Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2, 0.7f);
    }

  
    void Update()
    {
        
    }
}
