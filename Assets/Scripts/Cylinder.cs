using UnityEngine;
using UnityEngine.EventSystems;

//INHERITANCE inherit from Shapes
public class Cylinder : Shapes, IPointerClickHandler
{
    private void Awake()
    {
        shapeName = "Cylinder";
        shapeColor = "Pink";
    }
    //POLYMORPHISM override the DisplayText method from the base class
    public override void DisplayText()
    {
        Debug.Log("This is a Cylinder!");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        DisplayText();
    }
}
