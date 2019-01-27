using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text score = null;

    // Start is called before the first frame update
    void Start()
    {
        //float points = clickButton.ans / 8;
        score.text = "total: " + clickButton.ans.ToString() + "/8";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
