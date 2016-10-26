using UnityEngine;
using System.Collections;

public class OnTriggerExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log (other); 
		GetComponent<AudioSource>().Play(); 
	}
}
