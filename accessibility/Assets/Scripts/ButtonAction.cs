using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
    public void LaunchGame()
    {
        // Load the game scene (replace "GameScene" with your actual scene name)
        SceneManager.LoadScene("GameScene"); // Change "GameScene" to your actual scene name
        Debug.Log("Game has started.");
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
        Debug.Log("Game has been quit.");
    }

    public void OpenOptions()
    {
        // Logic to open the options menu
        Debug.Log("Opening Options Menu");
        // Here you can activate a UI panel or load another scene for settings
    }

    public void OpenSettings()
    {
        // Logic to open the settings menu
        Debug.Log("Opening Settings Menu");
        // Here you can activate a UI panel or load another scene for settings
    }
}
