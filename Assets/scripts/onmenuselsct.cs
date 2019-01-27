using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onmenuselsct : MonoBehaviour
{
    
    public ArrayList answers = new ArrayList() {"My son", "As much as is needed", "About 20 people", "blue is my son's favorite color",
        "Whatever most people like", "Birthday decorations", "A half sheet", "I dont care, a generic boy's birthday cake is fine",
        "My sons birthday, he's turning 10", "My son hates sprinkles", "Its a special birthday, so the bigger the better", "I want a fun boys rectangular cake"};

    public Dropdown questions;

    public Text text = null;
	public Text	countText = null;
	public int questionCount = 0;


    public void printAnswers(Dropdown question)
    {
        int val = question.value;
		
		questionCount++;
		
		countText.text = questionCount.ToString();
		
        text.text = (string) answers[val];

        answers.RemoveAt(val);


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
