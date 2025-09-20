using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PinballManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreText;

    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
