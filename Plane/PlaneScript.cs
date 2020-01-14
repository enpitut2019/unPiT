using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game"){
            transform.GetChild(0).gameObject.SetActive(true);
        }else{
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
