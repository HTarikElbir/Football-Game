using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageButton : MonoBehaviour
{
    GameObject btPause, btRestart, btResume, btMenu, gamePausedTxt;
    public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        gamePausedTxt = GameObject.Find("GamePaused");
        btResume = GameObject.Find("ResumeBt");
        btRestart = GameObject.Find("RestartBt");
        btPause = GameObject.Find("PauseBt");
        btMenu = GameObject.Find("MenuBt");
        DisplayPauseButtons(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartScene()
    {
       
        SceneManager.LoadScene("StartScene");
    } 
    public void GameScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Football");
    }
    public void ExitGame()
    {
        
        Application.Quit();
    }
    public void MenuScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
    }
    public void Pause()
    {
        paused = true;
        DisplayPauseButtons(true);
        Time.timeScale = 0;
    }
    void DisplayPauseButtons(bool state)
    {
        gamePausedTxt.SetActive(state);
        btResume.SetActive(state);
        btRestart.SetActive(state);
        btMenu.SetActive(state);
        btPause.SetActive(!state);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        DisplayPauseButtons(false);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Football");
    }
}
