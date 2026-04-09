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
        Debug.Log(other.gameObject.tag);

        if(other.gameObject.tag == "itemBoxes")
        {
            randomPowerUpIndex = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomPowerUpIndex];
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && chosenPowerup != null)
        {
            Vector3 pos = transform.position;
            pos += transform.forward * 5f;

            Instantiate(chosenPowerup, pos, Quaternion.identity);
            chosenPowerup = null;
        }
    }
}