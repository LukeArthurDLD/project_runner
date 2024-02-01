using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Forward Movement")]
    public float forwardMoveSpeed = 5f;
    private float currentSpeed;
    public float acceleration = 5f;
    [Header("Sideways Movement")]
    public float sidewaysMoveSpeed = 5f;

    private Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {        
        // SpeedControl();
    }
    public void ProcessMove(float input)
    {   
        //  constant forward movement
        rigidbody.AddForce(Vector3.forward * forwardMoveSpeed * 5);

        // horizontal movement
        rigidbody.MovePosition(rigidbody.position + transform.right * input * (sidewaysMoveSpeed * 5) * Time.deltaTime);

    }
    void SpeedControl()
    {
        
    }
    
}
