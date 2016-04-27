using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class FauxGravityBody : MonoBehaviour {

	public FauxGravityAttractor attractor;
	private Transform myTransform;
    private Rigidbody myRigidBody;

	void Start () {
        myRigidBody = GetComponent<Rigidbody>();
		GetComponent<Rigidbody>().useGravity = false;
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

		myTransform = transform;
	}

	void FixedUpdate () {

        myRigidBody.AddForce(transform.forward * 5);

		if (attractor){
			attractor.Attract(myTransform);
		}
	}
	
}
