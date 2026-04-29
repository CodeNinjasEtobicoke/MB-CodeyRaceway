using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TFL : MonoBehaviour
{
    public CheckmateCounter checkmateTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkmateTracker.triggeredCheckmates == checkmateTracker.numberOfCheckmates)
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
