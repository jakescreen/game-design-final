using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onmenuselsct : MonoBehaviour
{
    public ArrayList answers = null;
    public ArrayList customer1 = new ArrayList() {"Masga", "As much as is needed", "Aboutasfasf", "bluasfawewaef son's favorite color",
        "Whatever most people like", "Birthday decorations", "A half sheet", "I dont care, a generic boy's birthday cake is fine",
        "My sons birthday, he's turning 10", "My son hates sprinkles", "Its a special birthday, so the bigger the better", "I want a fun boys rectangular cake"};
    public ArrayList customer2 = new ArrayList() {"My son", "As much as is needed", "About 20 people", "blue is my son's favorite color",
        "Whatever most people like", "Birthday decorations", "A half sheet", "I dont care, a generic boy's birthday cake is fine",
        "My sons birthday, he's turning 10", "My son hates sprinkles", "Its a special birthday, so the bigger the better", "I want a fun boys rectangular cake"};

    public Dropdown questions;

    public Text text = null;
	public Text	countText = null;
	public int questionCount = 0;
    public static int customer = 1;


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
       if(customer == 1)
        {
            answers = customer1;
        }
       else if(customer == 2)
        {
            answers = customer2;
        }
        else
        {
            answers = customer1;
            customer = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
