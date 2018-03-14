using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour {

    public bool used;
    private Vector2 coordinate;
    public static int amountOfResources;
    public string resourceType; 
    
    public Resource(float x_axis,float y_axis, string resourceType )
    {
        coordinate = new Vector2(x_axis,y_axis);
        this.resourceType = resourceType;
        amountOfResources++;
    }

    public void isUsed()
    {
        if (used)
        {
            gameObject.SetActive(false);
        }
    }

    private bool checkMousePress(int rightOrLeftClick) {
        return Input.GetMouseButtonDown(rightOrLeftClick);
    }

    void OnMouseOver()
    {
        if (checkMousePress(0))
        {
            used = true;
        }
    }

	void Start () {
        used = false;
        amountOfResources = 0;
	}
    
    	
	void Update () {
        isUsed();
	}
}
