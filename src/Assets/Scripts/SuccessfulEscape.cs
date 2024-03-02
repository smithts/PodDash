using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class SuccessfulEscape : MonoBehaviour
{
	public string onTriggerEnterParameterName;
	public AudioClip OpenSound;
	public GameObject Menu;
	//public GameObject MainSection;
	public GameObject Player;
	public GameObject Stats;
	public GameObject TimeSection;
	public GameObject AlienSection;
	public GameObject DoorSection;
	public GameObject ReroutedSection;

    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "MainCamera" && onTriggerEnterParameterName != null)
		{
			gameObject.GetComponent<AudioSource>().PlayOneShot(OpenSound);
			Player.GetComponent<XRRayInteractor>().enabled = true;
			//Menu.SetActive(true);
			Stats.SendMessage("Finish");
			PopulateStats();
			Menu.SetActive(true);	

			
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.tag == "MainCamera" && onTriggerEnterParameterName != null)
		{
        	Player.GetComponent<XRRayInteractor>().enabled = false;
        }
    }

	void PopulateStats() 
	{
		StatTracker results = Stats.GetComponent<StatTracker>();
		
		string timeText = "Time: " + ProcessTime(results.timerText);
		string alienText = "Aliens Faced: " + results.aliens;
		string doorsText = "Jammed Doors: " + results.doors;
		string reroutedText = "Reroutes: " + results.rerouted;
			
		TimeSection.GetComponent<Text>().text = timeText;
		AlienSection.GetComponent<Text>().text = alienText;
		DoorSection.GetComponent<Text>().text = doorsText;
		ReroutedSection.GetComponent<Text>().text = reroutedText;
	}

	string ProcessTime(string input) {
		string result = input;
		
		if (input.StartsWith("0:")) 
		{
			input = input.Substring(2);
			if (input.StartsWith("0")) {
				input = input.Substring(1);
			}
			result = input + "s";
			
		} else if (input.StartsWith("0"))
		{
			result = input.Substring(1);
		}

		return result;
	}

}
