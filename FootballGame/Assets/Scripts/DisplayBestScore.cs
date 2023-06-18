using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayBestScore : MonoBehaviour
{
    private SpawnManager spawn2;
    private float bestScore;
    public Text yourBestScoreText;
    private float score2;
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject foundObject2 = GameObject.Find("SpawnMang");
        spawn2 = foundObject2.GetComponent<SpawnManager>();
        score2 = spawn2.score;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (score2>bestScore)
        {
            bestScore = spawn2.score;
        }
        yourBestScoreText.text = "Best Score: " + bestScore.ToString();
    }
}
