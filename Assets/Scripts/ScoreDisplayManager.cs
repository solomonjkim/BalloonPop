using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayManager : MonoBehaviour
{
    private int totalPoints;

    void UpdateDisplay(int points)
    {
        totalPoints += points;
        Text scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + totalPoints;
    }
    // Start is called before the first frame update
    void Start()
    {
        totalPoints = 0;
        UpdateDisplay(0);
    }

    void OnEnable()
    {
        BalloonController.onBalloonPop += UpdateDisplay;
    }

    void OnDisable()
    {
        BalloonController.onBalloonPop -= UpdateDisplay;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
