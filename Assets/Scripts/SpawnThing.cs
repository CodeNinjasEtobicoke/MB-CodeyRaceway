using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThing : MonoBehaviour
{
    public GameObject Maniac;
    public int modifyXPosititon;
    public int modifyZPosititon;
    public int numberOfRoses;
    void Start()
    {
        for (int i = 0; i < numberOfRoses; i++)
        {
            GameObject itemBoxClone = Instantiate(Maniac, new Vector3 (transform.position.x + modifyXPosititon * i, transform.position.y, transform.position.z + modifyZPosititon * i), transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
