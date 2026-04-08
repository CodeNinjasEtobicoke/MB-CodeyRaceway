using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ibf : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 100, 0);
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
    private void itemBoxGoAway()
    {
        gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("itemBoxGoAway", 0.5f);
            Invoke("itemBoxRespawn", 1f);
        }
    }

}
