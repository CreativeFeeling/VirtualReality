using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class foodPrefab : MonoBehaviour {

	public bool triggered = false;
	//public AudioClip bite;
	private float lowVol = 0.5f;
	private float highVol = 1.0f;
	//AudioSource source;

	// Use this for initialization
	void Start () {
		//source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		// Causes the food rotation to give more realistic throwing animation
		transform.Rotate (new Vector3 (Time.deltaTime * 0, -1, 0));
		// Checking if mouse is pressed and food is in the collider box of the player
		if (Input.GetMouseButtonDown (0) && triggered) {

			// Supposed to play sound bit but doesn't seem to work
			//float vol = Random.Range (lowVol, highVol);
			//source.PlayOneShot (bite, vol);

			// food is eaten so destroy the object
			Destroy (gameObject);


		}

	}

	void OnTriggerEnter(Collider other){
		
		if (other.tag == "Player"){
			triggered = true;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			triggered = false;
		}
	}


}


