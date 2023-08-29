using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour
{
    public Player player;
    public GameObject playButton;
    public GameObject gameOver;
    private Health startingHealth;

    private void Awake(){
        Application.targetFrameRate = 60;
        Pause();
    }
    public void Play(){
        
    }
    public void Pause(){
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void Gameover(){
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }
}
