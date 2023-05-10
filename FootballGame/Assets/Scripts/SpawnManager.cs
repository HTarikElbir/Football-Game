using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefabs;
    private float spawnRangeX = 10.0f;
    private float spawnPosZ = 20.0f;
    public bool spawnValue = true;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
       if(spawnValue == true)
        {
            SpawnObstacle();
            spawnValue = false;   
        }
            
    }
    void SpawnObstacle()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(obstaclePrefabs,spawnPosition,obstaclePrefabs.transform.rotation);
    }
}
