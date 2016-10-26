using UnityEngine;
using System.Collections;

public class RandomlyGenerateWaypoint : MonoBehaviour {

	public GameObject waypointPrefab; 

	void Start () {
		GameObject Player = GameObject.Find("GVRCam");
	}
	
	public void RandomNextWaypoint(){
		Vector3 position = new Vector3(Random.Range(-20.0f, 40.0f), 0, Random.Range(-20.0f, 40.0f));

		//	Instantiate the another waypoint at the random position set by the above vector3 with zero rotation
		Instantiate(waypointPrefab, position, Quaternion.identity);
	}
}
