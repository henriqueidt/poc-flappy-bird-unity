using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class floor : MonoBehaviour
{
    public float speed;
    private UnityEngine.Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(math.abs(transform.position.x - initialPosition.x) > 15) {
            transform.position = initialPosition;
        } else {
            // Vector3.left => new Vector3(-1, 0, 0)
            // Time.deltaTime => Interval in seconds from last frame to current
            transform.position += Vector3.left * speed * Time.deltaTime;    
        }
    }
}
