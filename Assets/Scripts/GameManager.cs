using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private GameObject cylinder;
    [SerializeField]
    private GameObject capsule;
    [SerializeField]
    private TMP_Text shapeData;
    [SerializeField]
    private TMP_Text gameText;
    private InputAction uiClickAction;
    private int clickCount = 0;


    private void Awake()
    {
        uiClickAction = InputSystem.actions.FindActionMap("UI").FindAction("Click");
    }

    private void OnEnable() => uiClickAction.Enable();
    private void OnDisable() => uiClickAction.Disable();
    void Start()
    {
        //ABSTRACTION
        SpawnRandomObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (uiClickAction.WasPressedThisFrame())
        {
            Vector2 screenPosition = Pointer.current.position.ReadValue();
            Ray ray = Camera.main.ScreenPointToRay(screenPosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Clicked object: " + hit.collider.gameObject.name);
                clickCount++;
                gameText.text = $"Clicked {clickCount} times";
                Shapes hitShape = hit.collider.GetComponent<Shapes>();

                if (hitShape != null)
                {
                    // 2. Access the variables through the script component
                    shapeData.text = $"Name: {hitShape.shapeName}\nColor: {hitShape.shapeColor}";
                }

                Destroy(hit.collider.gameObject);
                SpawnRandomObject();
            }
        }
    }
    public virtual void DisplayText()
    {
        Debug.Log("DISPLAY TEXT");
    }

    private void SpawnRandomObject()
    {
        // 1. Create a random number between 0 and 3
        int randomNumber = Random.Range(0, 3);
        Vector3 randomPosition = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(5f, 15f)));

        // 2. Use the random number to determine which object to create
        switch (randomNumber)
        {
            case 0:
                Instantiate(cube, randomPosition, Quaternion.identity);
                break;
            case 1:
                Instantiate(cylinder, randomPosition, Quaternion.identity);
                break;
            case 2:
                Instantiate(capsule, randomPosition, Quaternion.identity);
                break;
        }
    }

}
