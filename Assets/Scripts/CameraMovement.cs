using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //public float currentPosition;
    public GameObject foundObject;
    private Vector3 cameraPos;
    private Vector3 ballPos;
    private float maxHeight = 67f;
    Camera mainCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake () {
        cameraPos = transform.position;
    }

    void Start()
    {
        foundObject = GameObject.FindWithTag("ball");
        mainCamera = Camera.main;
        //foundObject = GameObject.Find()"ball");
        //cameraPos = transform.position; // initialize here
       //foundObject = GameObject.FindWithTag("ball");
       //currentPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
         ballPos = foundObject.transform.position;
         transform.rotation = Quaternion.identity;
        if (ballPos.y > 4.1f && ballPos.y < maxHeight) {
            cameraPos.y = ballPos.y;
            transform.position = cameraPos;
        }

        else {
            if (ballPos.y > maxHeight) {
                cameraPos.y = maxHeight;
            }
            else {
                cameraPos.y = 4.1f;
            }
            transform.position = cameraPos;
        }

        transform.rotation = Quaternion.identity;
            // Example: follow only X
            //cameraPos.x = ballPos.x;
    
    }
}
