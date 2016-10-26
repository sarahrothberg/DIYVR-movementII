using UnityEngine;
using System.Collections;

public class GoWhereYouGaze : MonoBehaviour {

	public float thrust; 
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		//every time user presses trigger, move forward by thrust amount
//		if (Input.GetMouseButtonDown(0)) {
//			transform.position += this.transform.forward * thrust;
//		}

//		when user holds down trigger, move forward by thrust amount normalized for different frame rate
		if (Input.GetMouseButton(0)) {
			transform.position += this.transform.forward * thrust * Time.deltaTime;
		}
	}
}
