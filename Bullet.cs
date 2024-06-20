using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public GameObject explosion;
    void Start()
    {
        
    }

  
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
