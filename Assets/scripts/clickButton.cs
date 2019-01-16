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

    public void changeText(string word)
    {
        text.text = word;
    }

    public void OnMouseUp()
    {
        Application.LoadLevel("SampleScene");
    }

    public void makeUnclickable(Button but)
    {
        but.interactable = false;
    }
}
