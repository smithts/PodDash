using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatTracker : MonoBehaviour
{
    private float startTime;
    private bool finished = false;
    public string timerText;
    public int aliens;
    public int doors;
    public int rerouted;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        aliens = 0;
        doors = 0;
        rerouted = 0;
    }

    void Restart() 
    {
        Start();
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void AddAlien() {
        if (!finished)
            aliens += 1;
    }

    public void AddDoor() {
       if (!finished)
            doors += 1;
    }

    public void AddReroute () {
        if (!finished)
            rerouted += 1;
    }

    public void Finish() 
    {
        if (finished)
            return;

        finished = true;

        float t = Time.time - startTime;

        int minutes = ((int)t / 60);
        int seconds = ((int)t % 60);

        timerText = minutes + ":" + seconds;
    }
}
