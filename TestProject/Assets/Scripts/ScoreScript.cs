using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TextMeshProUGUI scoreText; 
    private int score = 0; 

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void update()
    {
        
    }
}
