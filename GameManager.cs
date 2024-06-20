using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance;
    public TMP_Text scoreText;

    int score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
       
    }

    private void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score : " + score;
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    
}
