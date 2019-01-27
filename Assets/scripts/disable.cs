using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disable : MonoBehaviour
{
    public Toggle t1, t2, t3, vanilla, chocolate, redVelvet, red, blue, green, purple, white, small, medium, large, circle, rect, star;

    public void disbleOthersLayer1()
    {
        if (t1.isOn)
        {
            t3.interactable = false;
            t2.interactable = false;
        }
        else
        {
            t3.interactable = true;
            t2.interactable = true;
        }
    }
    public void disbleOthersLayer2()
    {
        if (t2.isOn)
        {
            t3.interactable = false;
            t1.interactable = false;
        }
        else
        {
            t3.interactable = true;
            t1.interactable = true;
        }
    }
    public void disbleOthersLayer3()
    {
        if (t3.isOn)
        {
            t2.interactable = false;
            t1.interactable = false;
        }
        else
        {
            t2.interactable = true;
            t1.interactable = true;
        }
    }
    public void disbleOthersFlavorV()
    {
        if (vanilla.isOn)
        {
            redVelvet.interactable = false;
            chocolate.interactable = false;
        }
        else
        {
            redVelvet.interactable = true;
            chocolate.interactable = true;
        }
    }
    public void disbleOthersFlavorC()
    {
        if (chocolate.isOn)
        {
            redVelvet.interactable = false;
            vanilla.interactable = false;
        }
        else
        {
            redVelvet.interactable = true;
            vanilla.interactable = true;
        }
    }
    public void disbleOthersFlavorR()
    {
        if (redVelvet.isOn)
        {
            chocolate.interactable = false;
            vanilla.interactable = false;
        }
        else
        {
            chocolate.interactable = true;
            vanilla.interactable = true;
        }
    }
    public void disbleOthersColorR()
    {
        if (red.isOn)
        {
            blue.interactable = false;
            white.interactable = false;
            green.interactable = false;
            purple.interactable = false;
        }
        else
        {
            blue.interactable = true;
            white.interactable = true;
            green.interactable = true;
            purple.interactable = true;
        }
    }
    public void disbleOthersColorB()
    {
        if (blue.isOn)
        {
            red.interactable = false;
            white.interactable = false;
            green.interactable = false;
            purple.interactable = false;
        }
        else
        {
            red.interactable = true;
            white.interactable = true;
            green.interactable = true;
            purple.interactable = true;
        }
    }
    public void disbleOthersColorG()
    {
        if (green.isOn)
        {
            blue.interactable = false;
            white.interactable = false;
            red.interactable = false;
            purple.interactable = false;
        }
        else
        {
            blue.interactable = true;
            white.interactable = true;
            red.interactable = true;
            purple.interactable = true;
        }
    }
    public void disbleOthersColorP()
    {
        if (purple.isOn)
        {
            blue.interactable = false;
            white.interactable = false;
            green.interactable = false;
            red.interactable = false;
        }
        else
        {
            blue.interactable = true;
            white.interactable = true;
            green.interactable = true;
            red.interactable = true;
        }
    }
    public void disbleOthersColorW()
    {
        if (white.isOn)
        {
            blue.interactable = false;
            red.interactable = false;
            green.interactable = false;
            purple.interactable = false;
        }
        else
        {
            blue.interactable = true;
            red.interactable = true;
            green.interactable = true;
            purple.interactable = true;
        }
    }
    public void disbleOthersSizeS()
    {
        if (small.isOn)
        {
            large.interactable = false;
            medium.interactable = false;
        }
        else
        {
            large.interactable = true;
            medium.interactable = true;
        }
    }
    public void disbleOthersSizeM()
    {
        if (medium.isOn)
        {
            large.interactable = false;
            small.interactable = false;
        }
        else
        {
            large.interactable = true;
            small.interactable = true;
        }
    }
    public void disbleOthersSizeL()
    {
        if (large.isOn)
        {
            small.interactable = false;
            medium.interactable = false;
        }
        else
        {
            small.interactable = true;
            medium.interactable = true;
        }
    }
    public void disbleOthersShapeC()
    {
        if (circle.isOn)
        {
            rect.interactable = false;
            star.interactable = false;
        }
        else
        {
            rect.interactable = true;
            star.interactable = true;
        }
    }
    public void disbleOthersShapeR()
    {
        if (rect.isOn)
        {
            circle.interactable = false;
            star.interactable = false;
        }
        else
        {
            circle.interactable = true;
            star.interactable = true;
        }
    }
    public void disbleOthersShapeS()
    {
        if (star.isOn)
        {
            rect.interactable = false;
            circle.interactable = false;
        }
        else
        {
            rect.interactable = true;
            circle.interactable = true;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
