using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballFlipperRight : MonoBehaviour
{
    [SerializeField]
    KeyCode flipKey;

    [SerializeField]
    Rigidbody2D myBody;

    AudioSource myCDPlayer;
    public AudioClip flipperCD;
    // Start is called before the first frame update
    void Start()
    {
        myCDPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(flipKey)) {
            myCDPlayer.PlayOneShot(flipperCD);
            myBody.AddForce(transform.up * 10000);
        }
    }
}
