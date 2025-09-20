using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballFlipper : MonoBehaviour
{
    [SerializeField]
    KeyCode flipKey;

    [SerializeField]
    Rigidbody2D myBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(flipKey)) {
            myBody.AddForce(transform.up * 500);
        }
    }
}
