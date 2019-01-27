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
        score.text = "total: " + clickButton.ans.ToString() + "/10";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
