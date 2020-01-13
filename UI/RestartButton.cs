using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("Clicked");
        // #if UNITY_EDITOR
        //     UnityEditor.EditorApplication.isPlaying = false;
        // #elif UNITY_STANDALONE
        //     UnityEngine.Application.Quit();
        // #endif
        SceneManager.LoadScene("GameStart");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
