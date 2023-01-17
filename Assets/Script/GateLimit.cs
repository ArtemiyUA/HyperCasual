using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateLimit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerSize.instance.BeerFunction();
            PlayerScore.instance.GateLimit();

        }
    }
}
