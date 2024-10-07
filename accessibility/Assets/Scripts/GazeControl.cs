using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GazeControl : MonoBehaviour
{
    public float gazeDuration = 2.0f;  // Time required to trigger the button
    public Image gazeIndicator;        // UI element to indicate gaze progress
    private float gazeTimer = 0f;
    private bool isGazing = false;
    private Button currentButton;

    void Update()
    {
        if (isGazing)
        {
            gazeTimer += Time.deltaTime;
            UpdateGazeIndicator();

            // Trigger the button click if the gaze duration is met
            if (gazeTimer >= gazeDuration)
            {
                TriggerButtonClick();
            }
        }
        else
        {
            gazeTimer = 0f;
            ResetGazeIndicator();
        }
    }

    public void StartGaze(Button button)
    {
        currentButton = button;
        isGazing = true;
    }

    public void StopGaze()
    {
        isGazing = false;
        currentButton = null;
    }

    private void TriggerButtonClick()
    {
        if (currentButton != null)
        {
            currentButton.onClick.Invoke(); // Trigger the button's OnClick event
            ResetGazeIndicator();
        }
    }

    private void UpdateGazeIndicator()
    {
        if (gazeIndicator != null)
        {
            gazeIndicator.fillAmount = gazeTimer / gazeDuration; // Update progress
        }
    }

    private void ResetGazeIndicator()
    {
        if (gazeIndicator != null)
        {
            gazeIndicator.fillAmount = 0f;  // Reset progress
        }
    }
}
