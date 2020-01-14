using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public Text playerScoreText;
    public Text leftText;  //1-5
    string left;
    public Text rightText;  //6-10
    string right;

    // Start is called before the first frame update
    void Start()
    {
    Debug.Log(PlayerPrefs.GetInt("Data"));

        playerScoreText.text="Your Score is "+PlayerDamage.playerScore;

    PlayerPrefs.SetInt("Data",PlayerDamage.playerScore);

        int[] arr = new int[10];
        
        left="";
        right="";
        for(int i=0;i<10;i++){
            if(i<5){
                left+=(i+1).ToString()+"  "+arr[i]+"pt\n";
            }else{
                right+=(i+1).ToString()+"  "+arr[i]+"pt\n";
            }
        }

        leftText.text=left;
        rightText.text=right;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
