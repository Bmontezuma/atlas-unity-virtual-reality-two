using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class GazeInteractor : MonoBehaviour
{
    public float gazeDuration = 2.0f;
    private float gazeTimer = 0.0f;
    private GameObject currentGazeObject;
    public Camera vrCamera;  // Reference to your VR Camera

    void Update()
    {
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = new Vector2(vrCamera.pixelWidth / 2, vrCamera.pixelHeight / 2);

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerEventData, results);

        if (results.Count > 0)
        {
            GameObject hitObject = results[0].gameObject;

            if (hitObject != currentGazeObject)
            {
                gazeTimer = 0.0f;
                currentGazeObject = hitObject;
            }

            gazeTimer += Time.deltaTime;

            if (gazeTimer >= gazeDuration)
            {
                ExecuteEvents.Execute(currentGazeObject, pointerEventData, ExecuteEvents.pointerClickHandler);
                Debug.Log("Gaze selected: " + currentGazeObject.name);
                gazeTimer = 0.0f;
            }
        }
        else
        {
            gazeTimer = 0.0f;
            currentGazeObject = null;
        }
    }
}
