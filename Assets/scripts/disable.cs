using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disable : MonoBehaviour
{
    public Toggle t1, t2, t3, vanilla, chocolate, redVelvet, red, blue, green, purple, white, small, medium, large, circle, rect, star;

    public void disbleOthersLayer1()
    {
        t3.interactable = false;
        t2.interactable = false;
    }
    public void disbleOthersLayer2()
    {
        t1.interactable = false;
        t3.interactable = false;
    }
    public void disbleOthersLayer3()
    {
        t1.interactable = false;
        t2.interactable = false;
    }
    public void disbleOthersFlavorV()
    {
        chocolate.interactable = false;
        redVelvet.interactable = false;
    }
    public void disbleOthersFlavorC()
    {
        vanilla.interactable = false;
        redVelvet.interactable = false;
    }
    public void disbleOthersFlavorR()
    {
        chocolate.interactable = false;
        vanilla.interactable = false;
    }
    public void disbleOthersColorR()
    {
        blue.interactable = false;
        green.interactable = false;
        purple.interactable = false;
        white.interactable = false;
    }
    public void disbleOthersColorB()
    {
        red.interactable = false;
        green.interactable = false;
        purple.interactable = false;
        white.interactable = false;
    }
    public void disbleOthersColorG()
    {
        blue.interactable = false;
        red.interactable = false;
        purple.interactable = false;
        white.interactable = false;
    }
    public void disbleOthersColorP()
    {
        blue.interactable = false;
        green.interactable = false;
        red.interactable = false;
        white.interactable = false;
    }
    public void disbleOthersColorW()
    {
        blue.interactable = false;
        green.interactable = false;
        purple.interactable = false;
        red.interactable = false;
    }
    public void disbleOthersSizeS()
    {
        medium.interactable = false;
        large.interactable = false;
    }
    public void disbleOthersSizeM()
    {
        small.interactable = false;
        large.interactable = false;
    }
    public void disbleOthersSizeL()
    {
        medium.interactable = false;
        small.interactable = false;
    }
    public void disbleOthersShapeC()
    {
        rect.interactable = false;
        star.interactable = false;
    }
    public void disbleOthersShapeR()
    {
        circle.interactable = false;
        star.interactable = false;
    }
    public void disbleOthersShapeS()
    {
        rect.interactable = false;
        circle.interactable = false;
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
