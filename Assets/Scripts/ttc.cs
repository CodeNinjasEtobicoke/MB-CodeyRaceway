using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ttc : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;
    public float totalCountdownTime;
    public float totalLapTime;
    public CodeyMove codeyMove;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            codeyMove.Speed = 0;
        }
        if (totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            codeyMove.Speed = 600;
        }
        if (totalCountdownTime < 0)
        {
            print("Times up bucko");
        }
    }
}
