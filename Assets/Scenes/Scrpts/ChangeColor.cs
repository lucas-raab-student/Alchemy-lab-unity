using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color modifiedColor = Color.red; // The color to change to
    private Color initialColor; // Store the initial color
    private bool isColorChanged = false; // Track if the color has been changed
    private float changeRate = 5f; // The speed at which the color change happens

    // Start is called before the first frame update
    void Start()
    {
        // Store the initial color of the object's material
        initialColor = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        // Smoothly transition to the target color
        GetComponent<Renderer>().material.color = Color.Lerp(
            GetComponent<Renderer>().material.color,
            GetTargetColor(),
            changeRate * Time.deltaTime
        );
    }

    // Determine the target color (either modified or initial)
    private Color GetTargetColor()
    {
        return isColorChanged ? modifiedColor : initialColor;
    }

    // Toggle the color change
    public void ToggleColor()
    {
        isColorChanged = !isColorChanged;
    }
}

