using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;

public class FinalScore : MonoBehaviour
{
    public Text score = null;

    // Start is called before the first frame update
    void Start()
    {
        float points = (((float) clickButton.ans) / 8.0f) * 100.0f;
        System.Console.WriteLine(points);
        score.text = "total: " + points.ToString() + "%";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
