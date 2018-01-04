using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InputAction : MonoBehaviour, IInputClickHandler, IHoldHandler {
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

    public void OnInputClicked(InputClickedEventData eventData)
    {
        //GetComponent<Renderer>().material.color = Color.red;
        //var rigidbody = gameObject.AddComponent<Rigidbody>();
        //rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }





    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
