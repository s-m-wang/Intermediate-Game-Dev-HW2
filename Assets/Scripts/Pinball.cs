using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinball : MonoBehaviour
{
    [SerializeField] Rigidbody2D myBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            myBody.bodyType = RigidbodyType2D.Dynamic;
            //myBody.linearVelocity = new Vector3(Random.Range(-5,5), Random.Range(-5,5));
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        switch (collision.gameObject.tag) {
            case "bumper" :
                myBody.AddForce(transform.up * 2000);
                break;
            case "wall" :
                myBody.AddForce(transform.up * 500);
                break;
        }
    }
}
