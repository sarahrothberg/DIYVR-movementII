using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {
	GameObject Player; 
	public GameObject LookAtTarget; 

	// Use this for initialization
	void Start () {
//		Player = GameObject.Find("GVRCam");
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt (LookAtTarget.transform); 
	}
}
