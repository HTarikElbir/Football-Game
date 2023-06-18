using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private bool changeValue;
    private SpawnManager spawn;
   
    
    
    void Start()
    {
       
        GameObject foundObject = GameObject.Find("SpawnMang");
        spawn = foundObject.GetComponent<SpawnManager>();
        
    }   
    void FixedUpdate()
    {
     

    }
    private void OnTriggerEnter(Collider other)
    {
        
        Destroy(gameObject);
        Destroy(other.gameObject);
       
        spawn.spawnValue = true;
        spawn.score += 5;
        // timeFReset.time =5;
        //timeFReset.timerSlider.maxValue = timeFReset.gameTime;
        Timer timerScript = FindObjectOfType<Timer>();
        timerScript.SetGameTime(5f);
    }
   
  
}
