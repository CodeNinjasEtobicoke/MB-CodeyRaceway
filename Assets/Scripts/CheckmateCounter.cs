using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckmateCounter : MonoBehaviour
{
    public int numberOfCheckmates;
    public int triggeredCheckmates;
    void Start()
    {
        numberOfCheckmates = GameObject.FindGameObjectsWithTag("checkmate").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
