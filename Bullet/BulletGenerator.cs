using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletGenerator : MonoBehaviour
{

    public GameObject BulletPrefabs;
    //float span = 1.0f;
    public float span ;
    float delta;
    bool waitTime;
    public Text countDown; 

    void Start(){
        delta=0;
        waitTime=true;
    }

    void Update()
    {
        Debug.Log(delta);
        this.delta += Time.deltaTime;

        if(waitTime==true){  //最初の1回のみ
            countDown.text=(3-Mathf.Floor(delta)).ToString();
            if(delta>3.0f){
                waitTime=false;
                countDown.text="";
            } 
        }else{
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject item = Instantiate(BulletPrefabs) as GameObject;
                float x = Random.Range(-50, 50);
                item.transform.position = new Vector3(x, 15, 45);
            }
        }
    }
}
