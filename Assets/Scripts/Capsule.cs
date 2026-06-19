using UnityEngine;
using UnityEngine.EventSystems;

public class Capsule : Shapes, IPointerClickHandler
{
    private void Awake()
    {
        shapeName = "Capsule";
        shapeColor = "Yellow";
    }
    public override void DisplayText()
    {
        Debug.Log("This is a Capsule!");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        DisplayText();
    }
}
