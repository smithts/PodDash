using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class exitScript3a : MonoBehaviour
{
	public string onTriggerEnterParameterName;
	public string onTriggerExitParameterName;
    public GameObject WarningDialogue;
    private bool visited = false;
    public GameObject door;
    public StatTracker Stats;
    public GameObject alien1;
    public GameObject alien2;
    public GameObject alien3;
    public GameObject alien4;

    void OnTriggerEnter(Collider other)
	{
        if(other.tag == "MainCamera" && onTriggerEnterParameterName != null)
        {
            if (!visited) {
                //only needs to do this portion once when door is first opened.
                visited = true;

                //need to activate nav mesh obstacle component on alien
                door.GetComponent<NavMeshObstacle>().enabled = true;
                //Rigidbody gameObjectsRigidBody = door.AddComponent<Rigidbody>(); // Add the rigidbody.
                //gameObjectsRigidBody.mass = 5;
                
                //Update Stats
                Stats.SendMessage("AddReroute");
                Stats.SendMessage("AddDoor");
            }

            //Neil to display message and play sound
            WarningDialogue.SetActive(true);
            alien1.SetActive(false);
            alien2.SetActive(false);
            alien3.SetActive(true);
            alien4.SetActive(true);
            //
        }


    }

	void OnTriggerExit(Collider other)
	{
		if(onTriggerExitParameterName != null)
		{
            //Neil to deactivate message and sound here
            WarningDialogue.SetActive(false);
            //
        }
    }
}
