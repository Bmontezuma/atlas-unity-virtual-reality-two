using UnityEngine;
using UnityEngine.UI;

public class GazeButton : MonoBehaviour
{
    private Button button; // Reference to the button component
    private bool isGazing = false;
    private float gazeTimer = 0f;
    public float gazeDuration = 2f; // Time in seconds to trigger click

    void Start()
    {
        button = GetComponent<Button>(); // Get the button component
    }

    void Update()
    {
        if (isGazing)
        {
            gazeTimer += Time.deltaTime;

            if (gazeTimer >= gazeDuration)
            {
                button.onClick.Invoke(); // Trigger the button's OnClick event
                ResetGaze();
            }
        }
    }

    public void OnGazeEnter()
    {
        isGazing = true;
        gazeTimer = 0f;
    }

    public void OnGazeExit()
    {
        ResetGaze();
    }

    private void ResetGaze()
    {
        isGazing = false;
        gazeTimer = 0f;
    }
}
