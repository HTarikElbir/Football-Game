using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Slider timerSlider;
    public Text timerText;
    public float gameTime;
    private float currentGameTime;
    private bool stopTimer = true;
    // Start is called before the first frame update
    void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
        currentGameTime = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopTimer)
            return;
        // float time = gameTime - Time.time;
        currentGameTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(currentGameTime / 60);
        int seconds = Mathf.FloorToInt(currentGameTime - minutes * 60);

        string textTime = string.Format("{0:0}:{1:00}",minutes,seconds);

        if (currentGameTime<= 0)
        {
            stopTimer = true;
            SceneManager.LoadScene("GameoverScene");
        }
        if (stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = currentGameTime;
        }
    }
    public void SetGameTime(float time)
    {
        gameTime = time;
        currentGameTime = gameTime;
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }
}
