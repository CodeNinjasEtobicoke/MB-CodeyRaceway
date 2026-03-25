using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TFL : MonoBehaviour
{
    public CheckmateCounter checkmateTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkmateTracker.triggeredCheckmates == checkmateTracker.numberOfCheckmates)
            {
                print("You win");
            }
            else
            {
                print("damn bro how desperate are u");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
