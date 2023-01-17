using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Walltrigger : MonoBehaviour
{
    public static Walltrigger instance;
    public int wallHealth;
    
    public void HitWall()
    {
        if (PlayerScore.playerScore > wallHealth)
        {
            PlayerScore.playerScore -= wallHealth;
        }if(PlayerScore.playerScore < wallHealth)
        {
            PlayerCollision.isDead = true;
            Debug.Log("Die");
        }
    }
    
    
}
