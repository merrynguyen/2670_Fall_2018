using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ForeachLoops : ScriptableObject
{
	public FloatData RandomSpeed;
	
	public List<FloatData> SpeedOptions;

	private void OnEnable()
	{
		var randomnum = Random.Range(0, SpeedOptions.Count - 1);
		for (int i = 0; i < SpeedOptions.Count-1; i++)
		{
			if (i == randomnum)
			{
				RandomSpeed = SpeedOptions[i];
			}
		}
	}
}
