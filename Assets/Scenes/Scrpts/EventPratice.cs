using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventPratice : MonoBehaviour
{
   public  UnityEvent testEvent =new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        testEvent.AddListener(TestListner);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            testEvent.Invoke();
        }
        
    }
    private void TestListner()
    {
        print("Called");
    }
}
