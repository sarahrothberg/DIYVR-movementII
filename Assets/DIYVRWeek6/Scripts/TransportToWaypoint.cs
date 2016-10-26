using UnityEngine;
using System.Collections;

public class TransportToWaypoint : MonoBehaviour {
	public GameObject waypointPrefab; 

	public GameObject Player; 

	void Start(){
	//	Player = GameObject.Find("GVRCam");
	}

	public void Transport(){
		Debug.Log ("player has moved from" + Player.transform.position); 
		Player.transform.position = this.transform.position;
		Debug.Log ("player has moved to" + Player.transform.position); 
	}


}
