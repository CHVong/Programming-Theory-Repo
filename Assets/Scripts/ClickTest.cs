using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems; // Required for the interface

public class ClickTest : MonoBehaviour, IPointerClickHandler
{
    // FIX: This exact method must exist to satisfy the interface contract
    public void OnPointerClick(PointerEventData eventData)
    {
        // This detects if someone clicks directly on the GameManager object itself
        Debug.Log("Clicked on GameManager GameObject: " + gameObject.name);
    }
}