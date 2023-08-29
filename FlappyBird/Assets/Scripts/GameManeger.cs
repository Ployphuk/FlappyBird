using UnityEngine;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour{
    public Player player;
    private Spawner spawner;
    public Health health;
    public GameObject playButton;
    public GameObject gameover;
    private void Awake(){
        Application.targetFrameRate = 60;

        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();


        Pause();
    }
    public void Play(){
        
        
        playButton.SetActive(false);
        gameover.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for(int i = 0; i< pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }

    }
    public void Pause(){
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver(){

        gameover.SetActive(true);
        playButton.SetActive(true);

        Pause();
        
    }
}