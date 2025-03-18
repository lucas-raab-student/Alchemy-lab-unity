using UnityEngine;

public class TurnObject : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f; // Speed of rotation
    private bool isRotating = false; // Whether the object is rotating
    private float currentRotation = 0f; // Current rotation value

    [SerializeField] private float maxRotationAngle = 360f; // Max rotation angle (full turn)
    private float rotationRate = 100f; // Rotation speed rate for smooth turning

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            // Rotate the object smoothly using the rotation speed and time
            float targetRotation = currentRotation + rotationSpeed * Time.deltaTime;
            currentRotation = Mathf.MoveTowards(currentRotation, targetRotation, rotationRate * Time.deltaTime);

            // Apply the rotation to the object
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

            // If the rotation exceeds the maximum allowed rotation, stop rotating
            if (currentRotation >= maxRotationAngle)
            {
                currentRotation = maxRotationAngle;
                isRotating = false;
            }
        }
    }


    public void ToggleRotation()
    {
        isRotating = !isRotating;
    }
}

