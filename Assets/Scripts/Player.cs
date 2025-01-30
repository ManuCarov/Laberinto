using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5f; 
    private float rotationSpeed = 700f; 
    public Transform cameraTransform; 

    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical"); 

        
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        
        forward.y = 0f;
        right.y = 0f;

        
        forward.Normalize();
        right.Normalize();

       
        Vector3 movement = forward * vertical + right * horizontal;
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        
        if (movement.magnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}

