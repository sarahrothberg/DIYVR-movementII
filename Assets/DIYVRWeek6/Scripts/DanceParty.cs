using UnityEngine;
using System.Collections;

public class DanceParty : MonoBehaviour {

	private bool macarena; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<Animator> ().SetBool("animationSwitcher", macarena); 
			macarena = !macarena; 
			Debug.Log ("h"); 
		}
	}
		
}
