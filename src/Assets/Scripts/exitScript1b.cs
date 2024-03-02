using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class exitScript1b : MonoBehaviour
{
	public string onTriggerEnterParameterName;
	public string onTriggerExitParameterName;
    public GameObject WarningDialogue;
    public GameObject destination;
    public GameObject Alien;
    public StatTracker Stats;
    private bool visited = false;


	void Start()
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
        if(other.tag == "MainCamera" && onTriggerEnterParameterName != null)
        {
            if (!visited) {
                //only needs to do this portion once when door is first opened.
                visited = true;

                //need to activate nav mesh obstacle component on alien
                destination.transform.position = new Vector3(-42f, 0.1f, -61.75f);
                Alien.SetActive(false);

                //Update Stats
                Stats.SendMessage("AddReroute");
                Stats.SendMessage("AddDoor");
            }

            //Neil to display message and play sound
            WarningDialogue.SetActive(true);
            //
        }


    }

	void OnTriggerExit(Collider other)
	{
		if(other.tag == "MainCamera" && onTriggerEnterParameterName != null)
		{
            //Neil to deactivate message and sound here
            WarningDialogue.SetActive(false);
            //
        }
    }
}
