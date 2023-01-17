using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMultiplication : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerSize.instance.GateFunctionMultiplication();
            PlayerScore.instance.MultiplicationScore();

        }
    }
}
