using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear: MonoBehaviour {
    // Use this for initialization
    void Start () {
        Invoke("ChangeScene", 3.0f);
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Title");
    }
}
