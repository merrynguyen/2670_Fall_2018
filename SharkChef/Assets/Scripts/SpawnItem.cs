using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnItem : MonoBehaviour
{
	public Transform[] SpawnPoints;
	public float spawnTime = 1.5f;
	public int randomrangeNumber;

	public GameObject[] Food;
	

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnFood", spawnTime, spawnTime);
		
		
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnFood()
	{
		int spawnIndex = Random.RandomRange(0, SpawnPoints.Length);


		int spawnGarbage = Random.RandomRange(1, randomrangeNumber);
		if (spawnGarbage == 1)
		{
			Instantiate(Food[3], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
		}
		else
		{
			int foodIndex = Random.RandomRange(0, Food.Length-1);
            Instantiate(Food[foodIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);

		}
		
	}
}


