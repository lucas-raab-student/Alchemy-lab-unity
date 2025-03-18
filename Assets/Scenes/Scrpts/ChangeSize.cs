
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
  [SerializeField]  private float Modifedscale = 2f;
    [SerializeField]private Vector3 Intialscale;
    private bool isscaled = false;
    private float changerate = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Intialscale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale=Vector3.MoveTowards(transform.localScale, GetTargetScale(), changerate * Time.deltaTime);
    }
    private Vector3 GetTargetScale()
    {
        return isscaled ? Vector3.one * Modifedscale : Intialscale;
    }
    public void ToggleScale()
    {
        isscaled = !isscaled;
    }
}
