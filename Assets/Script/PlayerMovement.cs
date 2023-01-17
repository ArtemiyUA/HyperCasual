using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float playerRange;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        float halfScreen = Screen.width / 2;
        float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
        float rangeXPos = Mathf.Clamp(xPos * playerRange, -playerRange, playerRange);

        playerTransform.localPosition = new Vector3(rangeXPos, 0, 0);
    }
}
