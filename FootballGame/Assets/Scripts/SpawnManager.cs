using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{

    private GameObject obstaclePrefabs;
    
    private float spawnRangeX = 10.0f;
    private float spawnPosZ = 20.0f;

    public bool spawnValue ;
    public float score = 0;
    private void Awake()
    {
        obstaclePrefabs =Resources.Load<GameObject>("Prefabs/Cube");
        
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnValue = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnValue == true)
        {
            SpawnObstacle();
            spawnValue = false;
        }
        UpdateScore();
    }
    public void SpawnObstacle()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);

        Instantiate(obstaclePrefabs,spawnPosition,obstaclePrefabs.transform.rotation);
    }


    public void UpdateScore() 
    {
       GameObject.Find("Score").GetComponent<Text>().text = "Score:" + score;
    }

   
}
