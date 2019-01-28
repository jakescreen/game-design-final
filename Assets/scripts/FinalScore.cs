using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;

public class FinalScore : MonoBehaviour
{
    public Text score = null;
    public Text flavor = null, color = null, deco = null, size = null, shape = null, Layer = null;
	public Image background1;
	public Image background2;

    // Start is called before the first frame update
    void Start()
    {
        float points = (((float) clickButton.ans) / 8.0f) * 100.0f;
        System.Console.WriteLine(points);
        score.text = "total: " + points.ToString() + "%";
//       if(onmenuselsct.customer == 1)
//       {
//			background1.enabled = true;
//			background2.enabled = false;
//       }
//       if(onmenuselsct.customer == 2)
//        {
//			background1.enabled = false;
//			background2.enabled = true;
//       }
		
        onmenuselsct.customer += 1;
        if(onmenuselsct.customer > 2)
        {
            onmenuselsct.customer = 1;
        }
       

        

    }

    // Update is called once per frame
    void Update()
    {
        // this is jank
        if (onmenuselsct.customer == 2)
        {
            Layer.text = "2";
            flavor.text = "chocolate";
            color.text = "purple";
            deco.text = "sprinkles";
            size.text = "large";
            shape.text = "circle";
        }
        else if (onmenuselsct.customer == 1)
        {
            Layer.text = "3";
            flavor.text = "vanilla";
            color.text = "blue";
            deco.text = "decorative icing, candles, writing";
            size.text = "medium";
            shape.text = "rectangle";
        }







        if (clickButton.layersCorrect)
        {
            Layer.color = Color.green;
        }
        else
        {
            Layer.color = Color.red;
        }
        if (clickButton.icingCorrect)
        {
            color.color = Color.green;
        }
        else
        {
            color.color = Color.red;
        }
        if (clickButton.decorCorrect4)
        {
            deco.color = Color.green;
        }
        else
        {
            deco.color = Color.red;
        }
        if (clickButton.sizeCorrect)
        {
            size.color = Color.green;
        }
        else
        {
            size.color = Color.red;
        }
        if (clickButton.shapeCorrect)
        {
            shape.color = Color.green;
        }
        else
        {
            shape.color = Color.red;
        }
        if (clickButton.flavorCorrect)
        {
            flavor.color = Color.green;
        }
        else
        {
            flavor.color = Color.red;
        }
    }
}
