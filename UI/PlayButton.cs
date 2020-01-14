using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    RaycastHit hit;
    //Vector3 center = new Vector3(Screen.width / 2, Screen.height / 2, 0);

    float distance = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClick()
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
        // //Vector3 center = ;   
        // Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        // Debug.DrawRay(ray.origin,ray.direction,Color.blue);
        // if(Physics.Raycast(ray, out hit, distance))
        // {
        //     //Debug.Log(hit.transform.position);
        //     if (hit.collider.tag == "Button")
        //     {
        //         //Debug.Log("now hitting");
        //     }
        // }
    }


}
