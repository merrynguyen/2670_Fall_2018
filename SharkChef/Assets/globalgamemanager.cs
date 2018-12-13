using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class globalgamemanager : MonoBehaviour
{
	public SaveData save;

	public GameObject sunglasses;
	public GameObject mustache;
	public GameObject knife;
	public float timer;
	public Text timerDisplay;
	
	
	

	// Use this for initialization
	void Start () {
		if (save.unlockSunglasses)
		{
			sunglasses.SetActive(true);
		}

		if (save.unlockMustache)
		{
			mustache.SetActive(true);
		
		}

		if (save.unlockKnife)
		{
			knife.SetActive(true);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > 0)
		{
			timer -= Time.deltaTime;
		}
		else if (timer <= 0)
		{
			timer = 0;
		}

		timerDisplay.text = string.Format("Time: {0:#.00}", timer);
	}
}
