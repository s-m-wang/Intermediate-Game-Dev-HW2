using UnityEngine;

public class BGMusic : MonoBehaviour
{
    AudioSource myCDPlayer;
    public AudioClip flipperCD;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCDPlayer = GetComponent<AudioSource>();
        myCDPlayer.loop = true;
        myCDPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
