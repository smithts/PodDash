using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class exitScript1a : MonoBehaviour
{
	public Animator animator;
	public string onTriggerEnterParameterName;
	public string onTriggerExitParameterName;
	public AudioClip OpenSound;
	public AudioClip CloseSound;
    public GameObject alien;
    private bool visited = false;
	public StatTracker Stats;


	void Start()
	{
		if(animator == null)
		{
			animator = GetComponent<Animator>();
			if(animator == null)
			{

			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
        if(other.tag == "MainCamera" && onTriggerEnterParameterName != null)
        {
            if (!visited) {
                //only needs to do this portion once when door is first opened.
                visited = true;

                //need to activate nav mesh obstacle component on alien
                alien.GetComponent<NavMeshObstacle>().enabled = true;

				//Update Stats
				Stats.SendMessage("AddReroute");
            }

            //open door and play animation sounds 
            gameObject.GetComponent<AudioSource>().PlayOneShot(OpenSound);
            animator.SetTrigger(onTriggerEnterParameterName);

        }
        
        
	}

	void OnTriggerExit(Collider other)
	{
		if(onTriggerExitParameterName != null)
		{
			gameObject.GetComponent<AudioSource>().PlayOneShot(CloseSound);
			animator.SetTrigger(onTriggerExitParameterName);
		}
	}
}
