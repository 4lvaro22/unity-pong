using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreTextLeft;
    public TMP_Text scoreTextRight;
    public static ScoreManager scoreManager;

    int scoreLeft = 0;
    int scoreRight = 0;


    public void Awake()
    {
        scoreManager = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreTextLeft.text = "Score P1: " + scoreLeft.ToString();
        scoreTextRight.text = "Score P2: " + scoreRight.ToString();
    }

    public void AddPointLeft()
    {
        scoreLeft++;
        scoreTextLeft.text = "Score P1: " + scoreLeft.ToString();
    }
    
    public void AddPointRight()
    {
        scoreRight++;
        scoreTextRight.text = "Score P2: " + scoreRight.ToString();
    }

}
