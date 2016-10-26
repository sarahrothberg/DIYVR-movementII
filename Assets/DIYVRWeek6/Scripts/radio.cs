using UnityEngine;
using System.Collections;

public class radio : MonoBehaviour {

	//for this script to run properly, you must have an audiosource on the object that this script is on in the inspector. 
	//the audiosource should be set to "play on awake"

	//create an public array of audio clips to hold the stations, drag the clips you want into the inspector
	public AudioClip[] myCoolRadioStations; 
	//create an interger to be incremented on keypress
	private int currentNum; 
	//create an audio source variable to be able to refer to the audio source
	private AudioSource myCoolRadiosAudioSource;
	// Use this for initialization

	void Start () {
		//set the audio source to the audiosource on THIS object (the one that this script is on) 
		myCoolRadiosAudioSource = GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update () {
		//detect keypress
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//set the audiosource to the array index
			myCoolRadiosAudioSource.clip = myCoolRadioStations [currentNum]; 
			//play that audiosource
			myCoolRadiosAudioSource.Play (); 
			//increment the array
			currentNum++; 
			//check to see if its reached the end and if so start it over! voila!
			if (currentNum == myCoolRadioStations.Length) {
				currentNum = 0; 
			}
		}
	}
}
