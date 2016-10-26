using UnityEngine;
using System.Collections;

public class InstantiateDestroy : MonoBehaviour {
	public GameObject ExamplePrefab;
//	public GameObject ExampleObject; 

	// Use this for initialization
	void Start () {
//		Invoke ("instantiateARandomPrefab", 2f); 
		InvokeRepeating ("instantiateARandomPrefab", 2f, 2f); 
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetMouseButtonDown (0)) {
//			Destroy (ExampleObject); 
//			Instantiate (ExamplePrefab); 
//			Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
//			Instantiate the example prefab at the random position set by the above vector3 with zero rotation
//			Instantiate(ExamplePrefab, position, Quaternion.identity);
//		}
	}

	public void instantiateARandomPrefab(){
			Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
			Instantiate(ExamplePrefab, position, Quaternion.identity);
	}
		
}
