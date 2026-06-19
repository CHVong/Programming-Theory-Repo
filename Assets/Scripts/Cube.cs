using UnityEngine;
using UnityEngine.EventSystems;
//INHERITANCE inherit from Shapes
public class Cube : Shapes, IPointerClickHandler
{
    private void Awake()
    {
        shapeName = "Cube";
        shapeColor = "Blue";
    }
    //POLYMORPHISM override the DisplayText method from the base class
    public override void DisplayText()
    {
        Debug.Log("This is a Cube!");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        DisplayText();
    }
}
