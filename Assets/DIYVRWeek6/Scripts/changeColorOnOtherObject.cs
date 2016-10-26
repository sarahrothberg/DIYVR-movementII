using UnityEngine;
using System.Collections;

public class changeColorOnOtherObject : MonoBehaviour {

	public GameObject otherObject; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
		{
			otherObject.GetComponent<Renderer> ().material.color = Color.red;
		}

	}
		
}
