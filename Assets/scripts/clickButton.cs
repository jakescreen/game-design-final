using System.Collections;
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
    public static bool layersCorrect, flavorCorrect, icingCorrect, sizeCorrect, decorCorrect1, decorCorrect2, decorCorrect3, decorCorrect4, shapeCorrect;

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
        Application.LoadLevel("End");
    }
    public void reset()
    {
        ans = 0;
        Application.LoadLevel("Start");
    }
    public void makeUnclickable(Button but)
    {
        but.interactable = false;
    }
    
}
