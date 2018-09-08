using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Should change name to SceneChanger but was lazy
// Original function was to control eating food

public class bite : MonoBehaviour {
	//public string foodfightRnd2;

	public const float TIME_LIMIT = 20F;
	public string roundNum;
	private float timer = 0F;

	void Start () {
		
	}
	
	// This script is in charge of changing the scenes based on a timer
	void Update () {

		timer += Time.deltaTime;
		if (timer >= TIME_LIMIT) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (roundNum);
		}

	}
}
