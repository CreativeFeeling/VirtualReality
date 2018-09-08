using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnfood : MonoBehaviour {

	public foodPrefab[] foodlist; //list of food prefabs
	public float minTime;
	public float maxTime;

	private float spawnTime = 0; // Set the spawn timer to zero


	private float time ; //current time

	// on game start each spawn spot sets the first spawn wait time
	// and sets time to minTime
	void Start () {
		spawnTime = SetSpawnTimer (); 
		time = minTime;


	}
	
	// fixed update adds actual passing time to the time variable
	// once time has succeeded the spawntime we spawn a food item reset the timer
	// and set time to zero to repeat the food spawning cycle
	void FixedUpdate () {
		time += Time.deltaTime;


		if (time >= spawnTime) {
			SpawnFood ();
			spawnTime = SetSpawnTimer ();
			time = 0;
		}


	}

	void SpawnFood(){
		
		int randfood = Random.Range (0, 6); // choosing random food index
		foodPrefab food = Instantiate<foodPrefab> (foodlist[randfood]); // creates instance of random food item

		food.transform.localPosition = transform.position; // spawns food item in position of the spawn area

		// throws the food
		// -2*randfood causes foods in the lower indexes to move slower than the foods in the higher indexes
		food.GetComponent<Rigidbody>().AddForce (transform.forward * Random.Range (-15-2*randfood, -17-2*randfood)); 
	}



	float SetSpawnTimer(){
		return(Random.Range (minTime, maxTime));
	}
}
