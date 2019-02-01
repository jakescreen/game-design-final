using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onmenuselsct : MonoBehaviour
{
    public ArrayList answers = null;
    public ArrayList customer1 = new ArrayList() {"Me", "I don't know, like 30 dollars?", "A bunch… I think Susan is coming… Or maybe not, I don’t know.", "Purple or green.",
        "Do you have lemon? Amy likes lemon. I think Amy is gonna be there.", "Just make it look nice, okay? But none of that fancy stuff.", "Medium, maybe.", "What kind of a question is that? Cake shaped?",
        "Does that really matter?", "You.", "Cakes have layers?", "Who's the cake-maker here? Me or you?"};
    public ArrayList customer2 = new ArrayList() {"My son", "As much as is needed", "About 20 people", "blue is my son's favorite color",
        "Whatever most people like", "Birthday decorations", "A half sheet", "I don't care, a generic boy's birthday cake is fine",
        "My sons birthday, he's turning 10", "My son hates sprinkles", "Its a special birthday, so the bigger the better", "I want a fun boys rectangular cake"};
	public ArrayList customer3 = new ArrayList() {"My best friend; she is getting married","About $400, but I'm willing to pay more for decorative icing.","About 100, so it should be as large with as many layers as possible.","White icing, since it's a wedding.","My best friend and her wife both love red velvet.","Decorative icing and writing with the names of the happy couple.","Large with as many layers as possible.","Rectangular sounds good.","It's a wedding, so the icing should be white. They want a red velvet cake.","No sprinkles or candles, please! Also avoid basic flavors, like chocolate and vanilla.","The cake should be large with 3 layers.","They would like a white rectangular cake with decorative icing and writing."};

    public Dropdown questions;

    public Text text = null;
	public Text	countText = null;
	public int questionCount = 0;
    public static int customer = 1;
	
	public Image background1;
	public Image background2;
	public Image background3;


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
			background1.enabled = true;
			background2.enabled = false;
			background3.enabled = false;
        }
       else if(customer == 2)
        {
            answers = customer2;
			background1.enabled = false;
			background2.enabled = true;
			background3.enabled = false;
        }
		else if(customer == 3)
		{
			answers = customer3;
			background1.enabled = false;
			background2.enabled = false;
			background3.enabled = true;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
