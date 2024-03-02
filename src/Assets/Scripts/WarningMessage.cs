using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningMessage : MonoBehaviour
{
	public string onTriggerEnterParameterName;
	public string onTriggerExitParameterName;
	public GameObject WarningDialogue;

	void OnTriggerEnter()
	{
		if (onTriggerEnterParameterName != null)
		{
			WarningDialogue.SetActive(true);

		}

	}
	void OnTriggerExit()
	{
		if (onTriggerExitParameterName != null)
		{
			WarningDialogue.SetActive(false);
		}
	}

}