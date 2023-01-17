using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateDivission : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerSize.instance.GateFunctionDivission();
            PlayerScore.instance.DivisionScore();

        }
    }
}
