// Using - Engine - UI - Scene Management - TMPro
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

// Public - Class - SceneSwitchTimerTMP
public class SceneSwitchTimerTMP : MonoBehaviour
{

    // Public - String - Scene To Load
    public string SceneToLoad;

    // Public - Float - Time Remaining Equals 120 / 2 minutes
    public float timeRemaining = 120;

    // Public - Bool - Timer Is Running = No / False
    public bool timerIsRunning = false;

    // Public - Text - Time Text
    public TMP_Text timeText;

    // Private - Void - Start
    private void Start()
    {
        // The Timer Starts Automatically = Yes / True
        timerIsRunning = true;
    }

    // Void - Update
    void Update()
    {

        // If Timer Is Running
        if (timerIsRunning)
        {

            // If Time Remaining Is Greater Than 0
            if (timeRemaining > 0)
            {
                // Timer Stuff

                // Time remaining
                timeRemaining -= Time.deltaTime;

                // Display Time - Time Remaining
                DisplayTime(timeRemaining);

                // Debug - Timer

                // Debug Log - Timer running
                Debug.Log("Timer is running!");

            }

            // Else If Time is 0 
            else
            {
                // Timer Stuff

                // Time - Remaining Is Equal To 0
                timeRemaining = 0;

                // Timer Is Not Running
                timerIsRunning = false;

                // Debug - Timer - Status

                // Debug Log - Time Ran Out
                Debug.Log("Time has run out!");

                // Scene Manager - Switch The Scene

                // Scene Manager - Load Scene
                SceneManager.LoadScene(SceneToLoad);

                // Debug - Switch Scene - Status

                // Debug Log - Scene Switched
                Debug.Log("Scene was switched!");

            }

        }

    }

    // Void - Display Time - Float - Time To Display
    void DisplayTime(float timeToDisplay)
    {

        // Time To Display
        timeToDisplay += 1;

        // Float - Minutes - Math - Floor To Int - Time To Display
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);

        // Float - Seconds - Math - Floor To Int - Time To Display
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        // Time Text - Text - String - Format
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

}
