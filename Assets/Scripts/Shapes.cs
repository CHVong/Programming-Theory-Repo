using UnityEngine;

public class Shapes : MonoBehaviour
{
    //ENCAPSULATION encapsulate the shapeName and shapeColor variables
    public string shapeName { get; protected set; }
    public string shapeColor { get; protected set; }
    public virtual void DisplayText()
    {
        Debug.Log("This is a Shapes base class!");
    }

}
