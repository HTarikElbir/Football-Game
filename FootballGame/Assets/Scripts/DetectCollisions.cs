using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private bool changeValue;
    private SpawnManager spawn;
    private Timer timeFReset;
    void Start()
    {
        GameObject foundObject = GameObject.Find("SpawnMang");
        spawn = foundObject.GetComponent<SpawnManager>();
        GameObject foundObject2 = GameObject.Find("Time");
        timeFReset = foundObject2.GetComponent<Timer>();
        
    }
    void FixedUpdate()
    {
        print(spawn.spawnValue);
    }
    private void OnTriggerEnter(Collider other)
    {
       
        Destroy(gameObject);
        Destroy(other.gameObject);
        spawn.spawnValue = true;
        spawn.score += 5;
        // timeFReset.time =5;
        //timeFReset.timerSlider.maxValue = timeFReset.gameTime;
        
    }
   
  
}
