using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float movDirection = 1.0f;
    public GameObject projectilePrefabs;
    private float xRange = 10.0f;
    private float speed = 10.0f;
    public AudioClip shotSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            movDirection *= -1;
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            movDirection *= -1;
        }

        transform.Translate(Vector3.right * Time.deltaTime * speed * movDirection);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefabs, transform.position, projectilePrefabs.transform.rotation);
            gameObject.GetComponent<AudioSource>().clip = shotSound;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
