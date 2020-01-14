using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public Text playerFinalScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("final score is "+PlayerDamage.playerScore);
        playerFinalScoreText.text="Your Score is "+PlayerDamage.playerScore;
    }
}
