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
        playerInput = new PlayerInput();
        driving = playerInput.Driving;

        playerMovement = GetComponent<PlayerMovement>();        
    }
    private void FixedUpdate()
    {
        playerMovement.ProcessMove(driving.Movement.ReadValue<float>()); 
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
