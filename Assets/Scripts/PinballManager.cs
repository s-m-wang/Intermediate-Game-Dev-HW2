using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PinballManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreText;

    [SerializeField]
    GameObject ballObj;

    int score = 0;
    int gumballCount = 0;
    public bool isDouble = false;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        scoreText.text = "Score: "+score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (gumballCount == 3) {
            isDouble = true;
        }
    }

    public void AddScore(int value) {
        if (isDouble) {
            score += (value*2);
            scoreText.text = "Score: 2x " + score.ToString();
        }
        else {
            score += value;
            scoreText.text = "Score: " + score.ToString();
        }
    }

    public void AddGumball() {
        gumballCount += 1;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            PlayerPrefs.SetInt("Score", 0);
            SceneManager.LoadScene("Pinball");
            //set the ball's position to its original position
            //ballObj.transform.position = ballStartPos;
        }
    }
}
