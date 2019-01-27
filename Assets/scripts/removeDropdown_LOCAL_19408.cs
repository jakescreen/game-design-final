using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class removeDropdown : MonoBehaviour
{
    // Start is called before the first frame update
    Dropdown drop = null;
	int testInt = 1;

    public void Removed(Dropdown drop)
    {
        int val = drop.value;
    }
  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
