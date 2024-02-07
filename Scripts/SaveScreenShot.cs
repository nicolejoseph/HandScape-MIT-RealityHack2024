using UnityEngine;

public class ScreenshotCapture : MonoBehaviour
{
    public string screenshotPath = "Screenshots/";
    public string screenshotPrefix = "Screenshot";
    public int captureInterval = 30; // in seconds

    public Camera mainCamera; // Assign your main camera here

    private float timer = 0f;

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Check if the specified time interval has passed
        if (timer >= captureInterval)
        {
            // Reset the timer
            timer = 0f;

            // Capture and save a screenshot
            CaptureAndSaveScreenshot();
        }
    }

    void CaptureAndSaveScreenshot()
    {
        // Get the path to the "Assets" folder
        string assetsPath = Application.dataPath;

        // Combine the "Assets" path with the screenshot folder path
        string screenshotsFolderPath = System.IO.Path.Combine(assetsPath, screenshotPath);

        // Create the folder if it doesn't exist
        if (!System.IO.Directory.Exists(screenshotsFolderPath))
        {
            System.IO.Directory.CreateDirectory(screenshotsFolderPath);
        }

        // Set the culling mask of the camera to exclude the Ultraleap hand
        int originalCullingMask = mainCamera.cullingMask;
        // Replace "UltraleapHand" with the actual layer of the hand
        // mainCamera.cullingMask &= ~(1 << LayerMask.NameToLayer("ExcludeFromScreenshot")); 
        mainCamera.cullingMask &= ~(1 << 3); 

        // Create a unique filename based on timestamp
        string timestamp = System.DateTime.Now.ToString("yyyyMMddHHmmss");
        string screenshotFilename = screenshotPrefix + "_" + timestamp + ".png";

        // Combine the path and filename
        string fullPath = System.IO.Path.Combine(screenshotsFolderPath, screenshotFilename);

        // Capture the screenshot
        ScreenCapture.CaptureScreenshot(fullPath);

        // Reset the camera's culling mask to the original value
        mainCamera.cullingMask = originalCullingMask;

        // Output a message to the console
        Debug.Log("Screenshot captured and saved: " + fullPath);
    }
}
