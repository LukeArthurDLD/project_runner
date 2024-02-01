using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.DrivingActions driving;

    private PlayerMovement playerMovement;
    private PlayerCamera playerCamera;

    private void Awake()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
    private void OnEnable()
    {
        driving.Enable();
    }
    private void OnDisable()
    {
        driving.Disable();
    }
}
