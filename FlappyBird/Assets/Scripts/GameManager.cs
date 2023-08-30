using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player player;
    private Spawner spawner;
    public Health health;

    [SerializeField]
    //public GameObject getReady;
    public GameObject playButton;
    public GameObject gameover;

    private void Awake()
    {
        player = FindObjectOfType<Player>();

        Time.timeScale = 1f;
        
        Application.targetFrameRate = 60;

        Play();
    }

    // public void GetReady()
    // {
    //     getReady.SetActive(true);

    //     playButton.SetActive(false);
    //     gameover.SetActive(false);
        
    //     if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
    //     {
    //         Time.timeScale = 1f;
    //         Play();
    //     }
    // }

    public void Play()
    {
        //getReady.SetActive(false);

        player.enabled = true;

        spawner = FindObjectOfType<Spawner>();
        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i< pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void GameOver()
    {
        gameover.SetActive(true);
        playButton.SetActive(true);

        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void WaitingToStart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("WaitingToStart");
    }
}