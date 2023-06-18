using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyAudio : MonoBehaviour
{
    public static AudioSource audioSource; // İkinci sahnede erişilecek AudioSource

    private void Start()
    {
        
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // Sahne geçişlerinde objenin yok olmasını engeller
    }

    public void LoadSceneWithAudio(string sceneName)
    {
        audioSource = GameObject.FindGameObjectWithTag("SA").GetComponent<AudioSource>();
        SceneManager.LoadScene(sceneName);
    }
    public void Button()
    {
        LoadSceneWithAudio("StartScene");
    }
}
