using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InputAction : MonoBehaviour, IInputHandler, IHoldHandler {

    HandDraggable handDraggable;
    Rigidbody body;
    Vector3 currentVelocity;

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

    void OnDraggingStarted()
    {
        
    }

    void OnDraggingStopped()
    {
        print("Drag stopped");
        print(currentVelocity);
        body.isKinematic = false;
        body.useGravity = true;
        body.velocity = currentVelocity;
    }



    // Use this for initialization
    void Start () {
        handDraggable = this.GetComponent<HandDraggable>();
        handDraggable.StartedDragging += OnDraggingStarted;
        handDraggable.StoppedDragging += OnDraggingStopped;
        
        body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        currentVelocity = body.velocity;
	}
}
