using UnityEngine;
using System.Collections;


public class BallBHV : MonoBehaviour {

	private float Speed = 20.0f;
	// Use this for initialization
	void Start () {
		rigidbody.AddForce(
			(transform.forward + transform.right)*Speed,
			ForceMode.VelocityChange );			
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
