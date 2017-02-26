using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody myRidgibody;
    private Vector3 moveInput;
    private Vector3 moveVelocity;

	// Use this for initialization
	void Start () {
        myRidgibody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //Horizontal and Vertical move acces
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        //Velocity to target direction
        moveVelocity = moveInput * moveSpeed;
	}

    void FixedUpdate ()
    {
        myRidgibody.velocity = moveVelocity;
    }
}
