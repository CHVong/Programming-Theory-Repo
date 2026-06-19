using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    private InputAction advanceAction;

    private void Awake()
    {
        // Bind both Space and Enter to a single action
        advanceAction = new InputAction(binding: "<Keyboard>/space");
        advanceAction.AddBinding("<Keyboard>/enter");
    }

    private void OnEnable() => advanceAction.Enable();
    private void OnDisable() => advanceAction.Disable();

    void Update()
    {
        if (advanceAction.WasPressedThisFrame())
        {
            SceneManager.LoadScene(0);
        }
    }
}