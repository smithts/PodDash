using UnityEngine;
using System.Collections;

public class exitScript1 : MonoBehaviour
{
	//public Animator animator;
	public string onTriggerEnterParameterName;
	//public string onTriggerExitParameterName;
    public GameObject destinationPoint;
    private bool visited = false;
	//public AudioClip OpenSound;
	//public AudioClip CloseSound;


	void Start()
	{
		//if(animator == null)
		//{
			//animator = GetComponent<Animator>();
			//if(animator == null)
			//{

			//}
		//}
	}

	void OnTriggerEnter()
	{
        if (onTriggerEnterParameterName != null & !visited) 
        {
            visited = true;
            destinationPoint.transform.position = new Vector3(18.89f, 0f, -3.69f);
        }
		// if(onTriggerEnterParameterName != null)
		// {
		// 	gameObject.GetComponent<AudioSource>().PlayOneShot(OpenSound);
		// 	animator.SetTrigger(onTriggerEnterParameterName);

		// }
	}

	void OnTriggerExit()
	{
		// if(onTriggerExitParameterName != null)
		// {
		// 	gameObject.GetComponent<AudioSource>().PlayOneShot(CloseSound);
		// 	animator.SetTrigger(onTriggerExitParameterName);

		// }
	}
}
