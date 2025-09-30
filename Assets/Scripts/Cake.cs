using UnityEngine;

public class Cake : MonoBehaviour
{

    [SerializeField]
    Rigidbody2D myBody;

    [SerializeField]
    GameObject ballObj;

    [SerializeField]
    GameObject cake;

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

    void OnTriggerEnter2D(Collider2D collision) { 
        switch (collision.gameObject.tag) {
            case "ball" :
                cake.SetActive(false);
                break;
        }
    }
}
