using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controllers : MonoBehaviour {

    public List<GameObject> trapObject;
    public Trap trap;
    private string Description;
    public int whichObject = 0;
    Toggle togg;


    public string getDescription()
    {
        return Description;
    }
    public void Toggle_Changed(bool newVal) {
        if (togg.isOn)
        {
            Description = trap.Description;

        }else
        {
            Description = "";
        }
    }

    // Use this for initialization
    void Start () {
        trap = trapObject[whichObject].GetComponent<Trap>();
        
        togg = GameObject.FindObjectOfType<Toggle>();
        togg.onValueChanged.AddListener(Toggle_Changed);
    }
	
    

	// Update is called once per frame
	void Update () {
        trap = trapObject[whichObject].GetComponent<Trap>();
    }
}
