using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{

    public GameObject BulletPrefabs;
    //float span = 1.0f;
    public float span ;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject item = Instantiate(BulletPrefabs) as GameObject;
            float x = Random.Range(-50, 50);
            item.transform.position = new Vector3(x, 15, 45);
        }
    }
}
