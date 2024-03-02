using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateAlien : MonoBehaviour
{
	public string onTriggerEnterParameterName;
	public GameObject Alien;

	void OnTriggerEnter()
	{
		if (onTriggerEnterParameterName != null)
		{
			Alien.SetActive(false);
		}
	}

}