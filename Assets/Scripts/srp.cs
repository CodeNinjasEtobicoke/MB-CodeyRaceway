using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class srp : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomPowerUpIndex;
    public GameObject chosenPowerup;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "itemBoxes")
        {
            randomPowerUpIndex = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomPowerUpIndex];
            Debug.Log(chosenPowerup.gameObject.name);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && chosenPowerup != null)
        {
            Vector3 pos = transform.position;
            pos += transform.forward * 5f;

            Debug.Log(chosenPowerup.gameObject.name);
            Instantiate(chosenPowerup, pos, transform.rotation);
            chosenPowerup = null;
        }
    }
}