using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRight : MonoBehaviour {
    public GameObject toggObject;
    private Controllers toggScript;
    Button curButton;
  
    void TaskOnClick()
    {
        
        toggScript.whichObject = (toggScript.whichObject + 1) % 3;
        
        
    }

    // Use this for initialization
    void Start () {
        curButton = GetComponent<Button>();
        curButton.onClick.AddListener(TaskOnClick);
       
        
    
        toggScript = (toggObject.GetComponent<Controllers>());
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
