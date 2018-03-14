using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour {
    private string Description;
    Controllers toggScript;
    public GameObject toggObject;
    InputField textToDisplay;
	// Use this for initialization
	void Start () {
        toggScript = toggObject.GetComponent<Controllers>();
        Description = toggScript.getDescription();
        textToDisplay = GetComponent<InputField>();
        
	}
	
	// Update is called once per frame
	void Update () {
        Description = toggScript.getDescription();
        textToDisplay.text = Description;

    }
}
