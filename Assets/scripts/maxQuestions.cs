using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maxQuestions : MonoBehaviour
{

    Text text = null;

    public Dropdown drop;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int num = drop.options.Count; //find how many questions have been asked

        if(num == 6) //total of 12 questions - if 6 remaining, disable dropdown
        {
            drop.interactable = false;

        }
    }
}
