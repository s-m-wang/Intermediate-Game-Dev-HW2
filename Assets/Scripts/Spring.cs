using UnityEngine;

public class Spring : MonoBehaviour
{
    private Vector3 springPos;
    private float force = 0f;
    private float maxForce = 500f;
    [SerializeField]
    Rigidbody2D myBody;

    [SerializeField]
    Rigidbody2D ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake() {
        springPos = myBody.position;
    }
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        springPos.x = 14.15f;
        myBody.MovePosition(springPos);
        //myBody.position.x = springPos.x;
        //springPos = transform.position;
        //force = 0f;
        //myBody.freeRotation = true;
        //check space is held down:
        if (Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space)) {
            if (springPos.y > -5f) {
                springPos.y = springPos.y - 5f * Time.deltaTime;
                if (force < maxForce)
                {
                    force = force + 3.5f * Time.deltaTime;
                }
                myBody.MovePosition(springPos);
            }   
            //hit max depth:
            else {
                springPos.y = -5f;
                myBody.MovePosition(springPos);
            }
            
        }
        else {
            if (springPos.y < 0.43f) {
                springPos.y = springPos.y + force;
            }
            else {
                springPos.y = 0.43f;
            }

            if (Input.GetKeyUp(KeyCode.Space)){
                //springPos.y = 0.43f;
                //spring up and add force
                //myBody.AddForce(transform.up * 5000);
                //Debug.Log("Released keys");
                force = 0f;
                //force = 0f;
            }
            //force = 0f;
            myBody.MovePosition(springPos);

        }

    }
}
