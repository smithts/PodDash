using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAliens : MonoBehaviour
{
	public string onTriggerEnterParameterName;
	public GameObject Alien2;
	public GameObject Alien3;

	void OnTriggerEnter()
	{
		if (onTriggerEnterParameterName != null)
		{
			Alien2.SetActive(true);
			Alien3.SetActive(true);
		}
	}

}