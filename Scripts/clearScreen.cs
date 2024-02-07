using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class ScreenClearer : MonoBehaviour
{
    public float clearInterval = 60f; // Time interval in seconds
    private float timer = 0f;
    private string initialSceneName;

    void Start()
    {
        // Store the initial scene name when the script starts
        initialSceneName = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Check if the specified time interval has passed
        if (timer >= clearInterval)
        {
            // Reset the timer
            timer = 0f;

            // Clear the screen and reload the initial scene
            ClearScreen();
        }
    }

    void ClearScreen()
    {
        // Reload the initial scene
        SceneManager.LoadScene(initialSceneName);

        // Output a message to the console
        Debug.Log("Screen cleared and scene reset");
    }
}


