using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField]private TextMeshProUGUI scoreText; // Reference to your UI Text element.

    void Start()
    {     
        InvokeRepeating("IncreaseScore", 0f, 0.1f);
    }

    void IncreaseScore()
    {
        score += 1;

        // Update the UI Text to display the new score.
        scoreText.text = score.ToString();
    }
}
