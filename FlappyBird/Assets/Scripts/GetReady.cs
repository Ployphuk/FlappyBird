using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetReady : MonoBehaviour
{
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Play();
        }
    }
    
    public void Play()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
