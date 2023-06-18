using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageAudio : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        // İlk sahnede etiketlenen AudioSource'u bulun
        GameObject[] audioSources = GameObject.FindGameObjectsWithTag("SA");
        if (audioSources.Length > 0)
        {
            audioSource = audioSources[0].GetComponent<AudioSource>();
        }
        Debug.Log(audioSource);
    }

    public void ToggleAudio()
    {
        Debug.Log(audioSource);
        // AudioSource'u kapatıp açın
        if (audioSource != null)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            else
            {
                audioSource.Play();
            }
        }
    }
}
