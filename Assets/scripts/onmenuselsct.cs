using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onmenuselsct : MonoBehaviour
{
    public ArrayList answers = null;
    public ArrayList customer1 = new ArrayList() {"Me", "I dunno, like 10 dollars?", "A bunch… I think Susan is coming… Or maybe not, I don’t know.", "I really feel like you should know that already.",
        "Do you have lemon? Amy likes lemon. I think Amy is gonna be there.", "Just make it look nice, okay? But none of that fancy stuff.", "I dunno, pretty big", "What kind of a question is that? Cake shaped?",
        "Does that really matter?", "You.", "Cakes have layers?", "Whos the cake-maker here? Me or you?"};
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
