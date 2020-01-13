using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamImage : MonoBehaviour
{
    int width = 1920;
    int height = 1080;
    int fps = 30;
    WebCamTexture webcamTexture;




    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture(devices[1].name, this.width, this.height, this.fps);
        GetComponent<Renderer>().material.mainTexture = webcamTexture;
        //if(webcamTexture.isPlaying==false) 
        webcamTexture.Play();
        DontDestroyOnLoad(gameObject);

        Debug.Log("playing is "+webcamTexture.isPlaying);
    }

    void Update(){
        //if(webcamTexture.isPlaying==false) 
        webcamTexture.Play();
    }


}