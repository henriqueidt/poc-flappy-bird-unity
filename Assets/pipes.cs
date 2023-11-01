using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3.left => new Vector3(-1, 0, 0)
        // Time.deltaTime => Interval in seconds from last frame to current
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
