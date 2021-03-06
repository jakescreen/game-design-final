﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickButton : MonoBehaviour
{
	//We are not sure what this variable does, but if we remove it, then everything breaks
	//DON'T REMOVE
    public int i;
	
	
    public Text text = null;
	
	//Not sure what these do, but you probably shouldn't delete them either, just sayin'
    public Button ruin;
    public Button fix;
	
    public Toggle t1, t2, t3, vanilla, chocolate, redVelvet, red, blue, green, purple, white, small, medium, large, circle, rect, star, icing
        , writing, sprinkles, candles;
    public static float ans = 0f;
	
	//Used for scoring
    public static bool layersCorrect, flavorCorrect, icingCorrect, sizeCorrect, decorCorrect, shapeCorrect;

	
    public void changeText(string word)
    {
        text.text = word;
    }

    public void toQuestion()
    {
        Application.LoadLevel("Question");
		
    }
    public void toInstructions()
    {
        Application.LoadLevel("Instructions");
    }
	//resets boolean values for answer displays
    public void toPostGame()
    {
        Application.LoadLevel("PostGame");
		layersCorrect = false;
        icingCorrect = false;
        flavorCorrect = false;
        shapeCorrect = false;
        sizeCorrect = false;
        decorCorrect = false;
    }
    public void nextCustomer()
    {
        ans = 0f;
		onmenuselsct.customer += 1;
        if(onmenuselsct.customer > 3)
        {
            onmenuselsct.customer = 1;
        }
        Application.LoadLevel("Question");
    }
    public void toCakeBake()
    {
        Application.LoadLevel("cakeBuild");
    }
	public void toEnd()
	{
		Application.LoadLevel("End");
	}
	
	//Adds up answer based on everything being correct
	//Varies base don customer
    public void changeToResults()
    {
        if(onmenuselsct.customer == 1)
        {
            if (t2.isOn)
            {
                ans += 1;
                layersCorrect = true;
            }
            if (chocolate.isOn)
            {
                ans += 1;
                flavorCorrect = true;
            }
            if (purple.isOn)
            {
                ans += 1;
                icingCorrect = true;
            }
            if (large.isOn)
            {
                ans += 1;
                sizeCorrect = true;
            }
            if (!icing.isOn && !candles.isOn && !writing.isOn && sprinkles.isOn)
            {
                ans += 1;
                decorCorrect = true;
            }
            if (circle.isOn)
            {
                ans += 1;
                shapeCorrect = true;
            }
        }
		else if(onmenuselsct.customer == 2)
        {
            if (t3.isOn)
            {
                ans += 1;
                layersCorrect = true;
            }
            if (vanilla.isOn)
            {
                ans += 1;
                flavorCorrect = true;
            }
            if (blue.isOn)
            {
                ans += 1;
                icingCorrect = true;
            }
            if (medium.isOn)
            {
                ans += 1;
                sizeCorrect = true;
            }
            if (icing.isOn && candles.isOn && writing.isOn && !sprinkles.isOn)
            {
                ans += 1;
                decorCorrect = true;
            }
            if (rect.isOn)
            {
                ans += 1;
                shapeCorrect = true;
            }
        }
		else if(onmenuselsct.customer == 3)
        {
            if (t3.isOn)
            {
                ans += 1;
                layersCorrect = true;
            }
            if (redVelvet.isOn)
            {
                ans += 1;
                flavorCorrect = true;
            }
            if (white.isOn)
            {
                ans += 1;
                icingCorrect = true;
            }
            if (large.isOn)
            {
                ans += 1;
                sizeCorrect = true;
            }
            if (icing.isOn && !candles.isOn && writing.isOn && !sprinkles.isOn)
            {
                ans += 1;
                decorCorrect = true;
            }
            if (rect.isOn)
            {
                ans += 1;
                shapeCorrect = true;
            }
        }
        
        Application.LoadLevel("Results");
    }
	//Resets to start
    public void reset()
    {
        ans = 0f;
        Application.LoadLevel("Start");
        onmenuselsct.customer = 1;
        layersCorrect = false;
        icingCorrect = false;
        flavorCorrect = false;
        shapeCorrect = false;
        sizeCorrect = false;
        decorCorrect = false;
    }
	//Used after toggle is pressed
    public void makeUnclickable(Button but)
    {
        but.interactable = false;
    }
    
}
