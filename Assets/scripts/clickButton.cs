﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class clickButton : MonoBehaviour
{
    public int i;
    public Text text = null;
    public Button ruin;
    public Button fix;
    public Toggle t1, t2, t3, vanilla, chocolate, redVelvet, red, blue, green, purple, white, small, medium, large, circle, rect, star, icing
        , writing, sprinkles, candles;
    public static int ans = 0;

    public void changeText(string word)
    {
        text.text = word;
    }

    public void changeLevel()
    {
        Application.LoadLevel("SampleScene");
    }
    public void changeToEnd()
    {
        if(t3.isOn == false)
        {
            ans += 1;
        }
        if (vanilla.isOn == false)
        {
            ans += 1;
        }
        if (blue.isOn == false)
        {
            ans += 1;
        }
        if (medium.isOn == false)
        {
            ans += 1;
        }
        if (icing.isOn == false)
        {
            ans += 1;
        }
        if (writing.isOn == false)
        {
            ans += 1;
        }
        if (candles.isOn == false)
        {
            ans += 1;
        }
        if (rect.isOn == false)
        {
            ans += 1;
        }
        Application.LoadLevel("EndScreen");
    }

    public void reset()
    {
        Application.LoadLevel("StartScreen");
    }
    public void makeUnclickable(Button but)
    {
        but.interactable = false;
    }
}
