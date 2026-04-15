using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sm : MonoBehaviour
{

    private void OnCollisionEnter(Collision shell)
    {
        if (shell.gameObject.tag == "obsticales")
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Debug.Log(transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }

}
