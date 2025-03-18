
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PushObject : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Push(float Strength)
    {
        Vector3 PushDirection=transform.position-Camera.main.transform.position;
        PushDirection.Normalize();
        rb.AddForce(PushDirection*Strength,ForceMode.Impulse);
    }
   
}

