using UnityEngine;

public class Gumdrop : MonoBehaviour
{

    [SerializeField]
    Rigidbody2D myBody;

    [SerializeField]
    GameObject ballObj;

    [SerializeField]
    GameObject gumdrop;

    [SerializeField]
    PinballManager myManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) { 
        switch (collision.gameObject.tag) {
            case "ball" :
                myManager.AddGumball();
                myBody.AddForce(transform.up * 1500);
                gumdrop.SetActive(false);
                break;
        }
    }
}
