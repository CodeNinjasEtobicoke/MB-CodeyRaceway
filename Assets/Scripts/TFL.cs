using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TFL : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("You win");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
