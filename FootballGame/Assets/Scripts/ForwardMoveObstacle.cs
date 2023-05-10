﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMoveObstacle : MonoBehaviour
{
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(transform.position.z < 10)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        }
    }
}
