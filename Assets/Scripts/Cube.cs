using UnityEngine;
using UnityEngine.EventSystems;

public class Cube : Shapes, IPointerClickHandler
{
    private void Awake()
    {
        shapeName = "Cube";
        shapeColor = "Blue";
    }
    public override void DisplayText()
    {
        Debug.Log("This is a Cube!");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        DisplayText();
    }
}
