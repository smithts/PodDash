using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAnimation : MonoBehaviour
{
	private Animator anim;
	private CharacterController controller;
	private int battle_state = 0;
	public GameObject AlienScreech;
	public StatTracker Stats;
	private bool encountered = false;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "MainCamera") 
		{
			if (!encountered) 
			{
				encountered = true;
				Stats.SendMessage("AddAlien");
			}
			
			anim = GetComponent<Animator>();
			controller = GetComponent<CharacterController>();
			anim.SetInteger("battle", 1);
			battle_state = 1;
			anim.SetInteger("moving", 7);
			AlienScreech.SetActive(true);
		}
		
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "MainCamera") 
		{
			anim = GetComponent<Animator>();
			controller = GetComponent<CharacterController>();
			anim.SetInteger("moving", 0);
			AlienScreech.SetActive(false);
		}
		
	}
}