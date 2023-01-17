using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorOil : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerSize.instance.OilFunction();
            PlayerScore.instance.DeductionScore();    
            Destroy(gameObject);
        }
    }
}
