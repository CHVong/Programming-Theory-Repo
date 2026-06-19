using UnityEngine;
using UnityEngine.EventSystems;
//INHERITANCE inherit from Shapes

public class Capsule : Shapes, IPointerClickHandler
{
    private void Awake()
    {
        shapeName = "Capsule";
        shapeColor = "Yellow";
    }
    //POLYMORPHISM override the DisplayText method from the base class
    public override void DisplayText()
    {
        Debug.Log("This is a Capsule!");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        DisplayText();
    }
}
