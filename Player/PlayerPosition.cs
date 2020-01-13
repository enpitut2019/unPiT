using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 position = InputTracking.GetLocalPosition(XRNode.CenterEye);
        myTransform.position = new Vector3(position.x*200,-20,49);
    }
}
