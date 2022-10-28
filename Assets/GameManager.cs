using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gameStartCanvas;
    public GameObject HighScore;
    private int i;
    private void Start()
    {
        GetComponent<AudioSource>().Play();
        gameStartCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    public void GameOver()
    {
        GetComponent<AudioSource>().Stop();
        gameOverCanvas.SetActive(true);
        HighScore.SetActive(true);
        Time.timeScale = 0;
    }
    public void GameStart()
    {
        gameStartCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
