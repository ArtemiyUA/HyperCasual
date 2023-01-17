using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerSize : MonoBehaviour
{
    public static PlayerSize instance;

    private float xScale, yScale, zScale;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void GateFunctionDivission()
    {
        // TEMP SCALE VALUES 
        xScale = this.transform.localScale.x;
        yScale = this.transform.localScale.y;
        zScale = this.transform.localScale.z;

        // SCALING
        xScale -= (0.010f / 2) * (PlayerScore.playerScore /10);
        yScale -= (0.010f / 2) * (PlayerScore.playerScore / 10);
        zScale -= (0.010f / 2) * (PlayerScore.playerScore / 10);

        // INCREASE SCALE 0.15F
        this.transform.DOScaleX(xScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleY(yScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleZ(zScale, 0.25f).SetEase(Ease.InOutSine);

    }

    public void GateFunctionMultiplication()
    {
        // TEMP SCALE VALUES 
        xScale = this.transform.localScale.x;
        yScale = this.transform.localScale.y;
        zScale = this.transform.localScale.z;

        // SCALING
        xScale += 0.010f * (PlayerScore.playerScore / 10);
        yScale += 0.010f * (PlayerScore.playerScore / 10);
        zScale += 0.010f * (PlayerScore.playerScore / 10);

        // INCREASE SCALE 0.15F
        this.transform.DOScaleX(xScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleY(yScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleZ(zScale, 0.25f).SetEase(Ease.InOutSine);

    }
    public void OilFunction()
    {
        // TEMP SCALE VALUES 
        xScale = this.transform.localScale.x;
        yScale = this.transform.localScale.y;
        zScale = this.transform.localScale.z;

        // SCALING
        xScale -= 0.010f;
        yScale -= 0.010f;
        zScale -= 0.010f;

        // INCREASE SCALE 0.15F
        this.transform.DOScaleX(xScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleY(yScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleZ(zScale, 0.25f).SetEase(Ease.InOutSine);

    }
    public void BeerFunction()
    {
        // TEMP SCALE VALUES 
        xScale = this.transform.localScale.x;
        yScale = this.transform.localScale.y;
        zScale = this.transform.localScale.z;

        // SCALING
        xScale += 0.010f;
        yScale += 0.010f;
        zScale += 0.010f;

        // INCREASE SCALE 0.15F
        this.transform.DOScaleX(xScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleY(yScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleZ(zScale, 0.25f).SetEase(Ease.InOutSine);
    }
}
