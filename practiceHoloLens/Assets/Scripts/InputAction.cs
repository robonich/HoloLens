using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InputAction : MonoBehaviour,  IInputClickHandler{

    public void OnInputClicked(InputClickedEventData eventData)
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
