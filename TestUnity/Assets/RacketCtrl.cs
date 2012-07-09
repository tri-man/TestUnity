using UnityEngine;
using System.Collections;

public class RacketCtrl : MonoBehaviour {
	
	private float Accel = 1000.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftArrow)) {
			this.transform.position.x += 1.0f;
		}else{ Input.GetKeyDown(KeyCode.RightArrow)){
			}
	}
}
