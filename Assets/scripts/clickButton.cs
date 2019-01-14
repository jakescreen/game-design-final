using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickButton : MonoBehaviour
{

    public Text text = null;
    public Button ruin;
    public Button fix;

    public void changeText(string word)
    {
        text.text = word;
    }

    public void makeUnclickable(Button but)
    {
        but.interactable = false;
    }
}
