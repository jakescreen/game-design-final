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
    public void toPostGame()
    {
        Application.LoadLevel("PostGame");
    }
    public void nextCustomer()
    {
        ans = 0;
        Application.LoadLevel("Question");
    }
    public void toCakeBake()
    {
        Application.LoadLevel("cakeBuild");
    }
    public void changeToEnd()
    {
        if(t3.isOn)
        {
            ans += 1;
        }
        if (vanilla.isOn)
        {
            ans += 1;
        }
        if (blue.isOn)
        {
            ans += 1;
        }
        if (medium.isOn)
        {
            ans += 1;
        }
        if (icing.isOn)
        {
            ans += 1;
        }
        if (writing.isOn)
        {
            ans += 1;
        }
        if (candles.isOn)
        {
            ans += 1;
        }
        if (rect.isOn)
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
