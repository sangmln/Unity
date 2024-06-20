using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1.3f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        transform.Translate(0, -distanceY, 0);

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
