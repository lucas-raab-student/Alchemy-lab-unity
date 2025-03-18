using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private Vector3 modifiedPosition = new Vector3(5f, 0f, 0f); // The position to move to
    private Vector3 initialPosition; // Store the initial position
    private bool isMoved = false; // Track if the object has been moved
    private float moveSpeed = 5f; // The speed at which the object moves

    // Start is called before the first frame update
    void Start()
    {
        // Store the initial position of the object
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Smoothly move to the target position
        transform.position = Vector3.MoveTowards(transform.position, GetTargetPosition(), moveSpeed * Time.deltaTime);
    }

    // Get the target position (either modified or initial)
    private Vector3 GetTargetPosition()
    {
        return isMoved ? modifiedPosition : initialPosition;
    }

    // Toggle the position change
    public void ToggleMove()
    {
        isMoved = !isMoved;
    }
}

