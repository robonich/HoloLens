using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InputAction : MonoBehaviour, IInputHandler, IHoldHandler {
    public void OnHoldCanceled(HoldEventData eventData)
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void OnHoldCompleted(HoldEventData eventData)
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void OnHoldStarted(HoldEventData eventData)
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void OnInputDown(InputEventData eventData)
    {
        print("Input Down");
    }

    public void OnInputUp(InputEventData eventData)
    {
        print("Input Up");
    }

    void OnDraggingStopped()
    {
        print("Drag stopped");
    }



    // Use this for initialization
    void Start () {
        var handDraggable = this.GetComponent<HandDraggable>();
        handDraggable.StoppedDragging += OnDraggingStopped;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
