using UnityEngine;
using UnityEngine.EventSystems;

public class Cylinder : Shapes, IPointerClickHandler
{
    private void Awake()
    {
        shapeName = "Cylinder";
        shapeColor = "Pink";
    }
    public override void DisplayText()
    {
        Debug.Log("This is a Cylinder!");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        DisplayText();
    }
}
