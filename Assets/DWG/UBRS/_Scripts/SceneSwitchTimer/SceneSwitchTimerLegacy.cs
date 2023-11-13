/*
*
*  Name: DWG Scene Switch Timer (Text Legacy)
*  File: SceneSwitchTimerLegacy.cs
*  Author: Deathwatch Gaming
*  License: MIT
*
*/

// Using - Engine - UI - Scene Management
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Namespace - DWG.UBRS.SceneSwitchTimerLegacy
namespace DWG.UBRS.SceneSwitchTimerLegacy
{

    // Public - Class - SceneSwitchTimerLegacy
    public class SceneSwitchTimerLegacy : MonoBehaviour
    {

        // Public - String - SceneToLoad
        public string SceneToLoad;

        // Public - Float - TimeRemaining - Equals 120 / 2 minutes
        public float timeRemaining = 120;

        // Public - Bool - TimerIsRunning = No / False
        public bool timerIsRunning = false;

        // Public - Bool - TimerEnabled = No / False
        public bool timerEnabled = false;

        // Public - Text - TimeText
        public Text timeText;

        // Void - Update
        void Update()
        {

            // If TimerEnabled - Equals To True
            if (timerEnabled == true)
            {

                // timeText - gameObject - Set Active - True
                timeText.gameObject.SetActive(true);

                // GetComponent - SceneSwitchTimerLegacy  - Enabled - True
                GetComponent<SceneSwitchTimerLegacy>().enabled = true;

                // Debug Log - Timer Is Enabled
                Debug.Log("The (Legacy) Timer is enabled!");

                // If TimerIsRunning - Equals To True
                if (timerIsRunning == true)
                {

                    // If TimeRemaining - Is Greater Than 0
                    if (timeRemaining > 0)
                    {

                        // TimeRemaining
                        timeRemaining -= Time.deltaTime;

                        // DisplayTime - Time Remaining
                        DisplayTime(timeRemaining);


                        // Debug Log - Timer running
                        Debug.Log("The (Legacy) Timer is running!");

                    } // Close - If TimeRemaining - Is Greater Than 0

                    // Else  
                    else
                    {

                        // Time - Remaining Is Equal To 0
                        timeRemaining = 0;

                        // TimerIsRunning - Equals False
                        timerIsRunning = false;

                        // Debug - Timer - Status

                        // Debug Log - Time Ran Out
                        Debug.Log("Time has run out!");

                        // Scene Manager - Switch The Scene

                        // Scene Manager - Load Scene
                        SceneManager.LoadScene(SceneToLoad);

                        // Debug Log - Scene Switched
                        Debug.Log("The Scene was switched!");

                    } // Close - Else  

                } // Close - If TimerIsRunning - Equals To True

                // Else If TimerIsRunning - Equals To False
                else if (timerIsRunning == false)
                {

                    // Timer Is Not Running
                    timerIsRunning = false;

                    // Debug Log - Timer Is Not Running
                    Debug.Log("The (Legacy) Timer is not running!");

                } // Close - If TimerIsRunning - Equals To False

            } // Close - If TimerEnabled - Equals To True

            // Else If TimerEnabled - Equals To False
            else if (timerEnabled == false)
            {

                // timeText - gameObject - Set Active - False
                timeText.gameObject.SetActive(false);

                // GetComponent - SceneSwitchTimerLegacy  - Enabled - false
                GetComponent<SceneSwitchTimerLegacy>().enabled = false;

                // Debug Log - Timer Is Not Enabled
                Debug.Log("The (Legacy) Timer is not enabled!");

                // Timer Is Not Running
                timerIsRunning = false;

            } // Close Else If TimerEnabled - Equals To False

        } // Close - Void - Update

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

        } // Close - Void - Display Time - Float - Time To Display

    } // Close - Public - Class - SceneSwitchTimerLegacy

} // Close - Namespace - DWG.UBRS.SceneSwitchTimerLegacy
