using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
	public float destroyTime;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, destroyTime);

		{
			Physics.gravity = new Vector3(0, -5.0f, 0);
		}
		
		
	}

}
