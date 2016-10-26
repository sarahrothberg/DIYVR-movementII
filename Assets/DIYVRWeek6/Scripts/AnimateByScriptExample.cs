using UnityEngine;
using System.Collections;

public class AnimateByScriptExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
//		transform.Translate (Vector3.forward * 3f * Time.deltaTime);

			if (Input.GetMouseButton (0)) {
			//rotate by 45 degrees once per frame update
//			transform.Rotate(Vector3.up, 45f);
//			rotate by 45 degrees every second, independent of framerate of device
//			transform.Rotate(Vector3.up, 45f* Time.deltaTime);
			}
		}
	}