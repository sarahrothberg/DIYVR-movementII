using UnityEngine;
using System.Collections;

public class changeColorOnThisObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.E))
		{
//			transform.position = transform.position*2; 
//			GetComponent<Renderer> ().material.color = Color.green;
			GetComponent<AudioSource>().enabled = true; 
		}
	}
}
