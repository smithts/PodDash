using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuController : MonoBehaviour
{
    public GameObject LocomotionSystem;
    public GameObject Player;
    public GameObject Stats;
    //public GameObject Menu;

    // Create function for loading main scene
    public void StartBtn()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void MenuBtn() 
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void BeginGame() 
    {
        LocomotionSystem.SetActive(true);
        Player.GetComponent<XRRayInteractor>().enabled = false;
        Stats.SendMessage("Restart");
        gameObject.SetActive(false);

    }

    // Start is called before the first frame update
    void Start()
    {
        if (LocomotionSystem) 
        {
            LocomotionSystem.SetActive(false);
        }

        if (Player) 
        {
            Player.GetComponent<XRRayInteractor>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
