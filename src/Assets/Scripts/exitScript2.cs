using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class exitScript2 : MonoBehaviour
{
	public string onTriggerEnterParameterName;
	public string onTriggerExitParameterName;
    public GameObject WarningDialogue;
    public GameObject destination;
    public GameObject alien1;
    public GameObject alien2;
    private bool visited = false;
    public StatTracker Stats;


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

                // move destination and activate alien1 and 2
                destination.transform.position = new Vector3(59f, 0.01f, -36f);
                alien1.SetActive(true);
                alien2.SetActive(true);

                //Updates Stats
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
