using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //public PlayerDamage playerDamage;
    public float advanceBullet = -1.0f;

    void Update()
    {
        transform.Translate(0, this.advanceBullet, 0);
        if (transform.position.y < -35.0f)
        {
            //Debug.Log(gameObject.tag);
            if(gameObject.tag=="Enemy") PlayerDamage.playerScore+=1; //when you avoid an enemy, you can get 1pt in player score.
            //Debug.Log("score is"+PlayerDamage.playerScore);
            Destroy(gameObject);
        }
    }
}
