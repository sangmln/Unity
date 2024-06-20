using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {
        InvokeRepeating("Shooting", 1f, 1f);
    }

    void Shooting()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
    void Update()
    {
        
    }
}
