using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    public PenguinMovement penguinMovementscript;
    public GameObject demoFinish;
    


    private int score = 0;
    [SerializeField]private TextMeshProUGUI scoreText; // Reference to your UI Text element.

    void Start()
    {     
        InvokeRepeating("IncreaseScore", 0f, 0.1f);
    }
    private void LateUpdate()
    {
        if (score == 300)
        {
            Time.timeScale = 0;
            demoFinish.SetActive(true);
            penguinMovementscript.walkingSFX.Stop();
            penguinMovementscript.slidingSFX.Stop();
            penguinMovementscript.jumpingSFX.Stop();
            
        }
    }

    void IncreaseScore()
    {
        score += 1;

        // Update the UI Text to display the new score.
        scoreText.text = score.ToString();
    }
}
