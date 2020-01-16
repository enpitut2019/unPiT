using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletGenerator : MonoBehaviour
{

    public GameObject BulletPrefabs;
    public float span;
    float delta;

    //CountDown countDown;
    

    //float firstSpan;

    void Start(){
        delta=0;
        //waitTime=true;
        //firstSpan=span;
    }

    void Update()
    {
        //Debug.Log(delta);
        this.delta += Time.deltaTime;

        if(CountDown.waitTime){  //最初の1回のみ

        }else{
            if (this.delta > this.span){
                this.delta = 0;
                span*=0.99f;
                //Debug.Log("span is "+firstSpan.ToString()+" => "+span.ToString());
                GameObject item = Instantiate(BulletPrefabs) as GameObject;
                float x = Random.Range(-50, 50);
                item.transform.position = new Vector3(x, 15, 45);
            }
        }
    }
}
