using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinball : MonoBehaviour
{
    [SerializeField] Rigidbody2D myBody;

    [SerializeField]
    PinballManager myManager;

    AudioSource myCDPlayer;
    public AudioClip dingCD;
    public AudioClip jellyCD;
    public AudioClip wooshCD;
    public AudioClip donutCD;
    public AudioClip cakeCD;

    

    // Start is called before the first frame update
    void Start()
    {
        myCDPlayer = GetComponent<AudioSource>();
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
                myCDPlayer.PlayOneShot(dingCD);
                break;
            case "pop" :
                myBody.AddForce(transform.up * 2000);
                myCDPlayer.PlayOneShot(wooshCD);
                myManager.AddScore(300);
                break;
            case "spin" :
                myBody.AddForce(transform.up * 2000);
                myCDPlayer.PlayOneShot(donutCD);
                myManager.AddScore(200);
                break;
            case "wall" :
                myBody.AddForce(transform.up * 500);
                break;
            case "gumdrop" :
                myBody.AddForce(transform.up * 1000);
                myCDPlayer.PlayOneShot(jellyCD);
                myManager.AddScore(100);
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("spin"))
        {
            //Vector2 dirVec = new Vector2(collision.gameObject.transform.up.x, collision.gameObject.transform.up.y);
            myBody.linearVelocity += (Vector2)collision.gameObject.transform.up * 20;
        }
        if (collision.CompareTag("cake")) {
            myBody.AddForce(transform.up * 500);
            myCDPlayer.PlayOneShot(cakeCD);
            myManager.AddScore(1000);
        }

    }
}
