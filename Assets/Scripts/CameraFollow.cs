using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform cameraTransform; // Referencia a la c�mara

    void Update()
    {
        Vector3 forward = cameraTransform.forward;
        forward.y = 0; // Evita inclinar al personaje
        transform.forward = forward; // Apunta en la misma direcci�n que la c�mara
    }
}



