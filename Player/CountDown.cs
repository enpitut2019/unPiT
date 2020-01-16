using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    float delta;
    public static bool waitTime;
    //public Text countDown; 
    // public AudioSource countDownSound;
    // public AudioSource playingSound;
    AudioSource audioSource;
    public AudioClip sound;

    // public Image one;
    // public Image two;
    // public Image thr;



    // Start is called before the first frame update
    void Start()
    {
        delta=0;
        waitTime=true;
        audioSource = gameObject.AddComponent<AudioSource>();
        transform.GetChild(2).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        this.delta += Time.deltaTime;

        if(waitTime){  //カウントダウンしている間 //クソコードでゴメン
            //Debug.Log(delta);
            //countDown.text=(3-Mathf.Floor(delta)).ToString();
            if(delta>1.0f){
                transform.GetChild(2).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);
                if(delta>2.0f){
                    transform.GetChild(0).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.SetActive(false);
                    if(delta>3.0f){
                        transform.GetChild(0).gameObject.SetActive(false);
                        waitTime=false;
                        audioSource.PlayOneShot(sound);
                        //audioSource.Play();
                        //countDown.text="";
                    } 
                }
            }
        }

    }
}


//transform.GetChild(0).gameObject.SetActive(true);