using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float advanceBullet = -1.0f;

    void Update()
    {
        transform.Translate(0, this.advanceBullet, 0);
        if (transform.position.y < -30.0f)
        {
            Destroy(gameObject);
        }
    }
}
