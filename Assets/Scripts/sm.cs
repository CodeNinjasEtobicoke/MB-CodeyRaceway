using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class sm : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obsticales")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
    private void Start()
    {
        Debug.Log(transform.forward);
    }
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }
}