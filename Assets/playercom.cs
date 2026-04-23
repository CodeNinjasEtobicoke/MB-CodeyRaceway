using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class playercom : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "terrain")
        {
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
