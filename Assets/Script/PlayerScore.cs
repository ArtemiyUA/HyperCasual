using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class PlayerScore : MonoBehaviour
{   
    public static PlayerScore instance;
    [SerializeField] TextMeshProUGUI textScore;
    public static int playerScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {
        textScore.text = playerScore.ToString();     
    }

    private void Start()
    {      
        playerScore = 0;     
    }

    public void AdditionScore() // +
    {
        playerScore += 10;
    }

    public void MultiplicationScore()  //*
    {
        playerScore *= 2;
    }

    public void DeductionScore() //-
    {
        playerScore -= 10;
        
        if(playerScore < 0)
        {
            GetComponent<PlayerCollision>().Die();
            Debug.Log("Game over");
        }
    }
    public void DivisionScore() // /
    {
        playerScore /= 2;
    }

   
    public void GateLimit()
    {
        if(playerScore >= 50)
        {
            playerScore += 20;
        }
        if(playerScore < 50)
        {
            GetComponent<PlayerCollision>().Die();
        }
    }

    

}
