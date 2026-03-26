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

    private bool raceStarted = false;

    void Start()
    {
        lapTime.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (totalCountdownTime > 0 && raceStarted == false)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            codeyMove.Speed = 0;
        }
        else if (totalCountdownTime <= 0 && raceStarted == false)
        {
            //Stop the Countdown
            startCountdown.text = " ";
            totalLapTime -= Time.deltaTime;
            
            //Start the Lap Time Countdown
            codeyMove.Speed = 800;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            raceStarted = true;
        }

        if (raceStarted == true)
        {
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();

        }
        if (totalLapTime <= 0)
        {
            print("Times up bucko");
            codeyMove.Speed = 0;
        }
    }
}
