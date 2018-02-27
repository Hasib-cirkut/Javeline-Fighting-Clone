using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JavelineSpawner : MonoBehaviour {

	public GameObject javeline;
	public GameObject SpawnPoint;

	
	void Update () {

		Vector3 pos = Camera.main.WorldToViewportPoint(javeline.transform.position);

		if(pos.x > 1.0)
		{
			//Invoke("SpawnJaveline", 1.5f);
			SpawnJaveline();
		}		
		
	}

	void SpawnJaveline()
	{
		Instantiate(javeline, SpawnPoint.transform.position, Quaternion.identity );
	}
}
