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
        playerScoreText.text="Your Score is "+PlayerDamage.playerScore;

        const int N=10; //表示するスコアの数（偶数がいい）

        int[] arr = new int[N];
        // execute for the first time
        // for(int i=0;i<10;i++){ arr[i]=0; }
        // for(int i=0;i<10;i++){ PlayerPrefs.SetInt("Data"+i.ToString(),arr[i]); }  //store to allHighScore

        for(int i=0;i<N;i++){ arr[i]=PlayerPrefs.GetInt("Data"+i.ToString()); }  //load from allHighScore

        int m=N;  //今回のスコアが入るインデックスをメモする変数
        for(int i=0;i<N;i++){ if(arr[N-1-i]<PlayerDamage.playerScore){ m=N-1-i; }}  //mを求める
        if(m<N){
            if(m<N-1){ for(int i=N-1;i>m;i--){ arr[i]=arr[i-1]; }}  //m以降順番をひとつずつずらす
            arr[m]=PlayerDamage.playerScore;
        }

        for(int i=0;i<N;i++){ PlayerPrefs.SetInt("Data"+i.ToString(),arr[i]); }  //store to allHighScore

        left="";
        right="";
        for(int i=0;i<N;i++){
            if(i<N/2){ left+=(i+1).ToString()+"  "+arr[i]+"pt\n"; }
            else{ right+=(i+1).ToString()+"  "+arr[i]+"pt\n"; }
        }

        leftText.text=left;
        rightText.text=right;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
