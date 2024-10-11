using UnityEngine;
using UnityEngine.EventSystems;

public class GazeInteractable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer Enter: " + gameObject.name);
        // Visual indication for gaze enter
        GetComponent<UnityEngine.UI.Image>().color = Color.red; // Example: Change color on gaze enter
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer Exit: " + gameObject.name);
        // Visual indication for gaze exit
        GetComponent<UnityEngine.UI.Image>().color = Color.white; // Example: Revert color on gaze exit
    }
}
