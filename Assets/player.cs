using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rig;
    private game game;
    public float jumpForce = 1f;
    // Start is called before the first frame update
    void Start()
    {
        // Finds the component associated with the object
        rig = GetComponent<Rigidbody2D>();
        game = FindObjectOfType<game>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Vector2.up => new Vector(0,1)
            rig.velocity = Vector2.up * jumpForce;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        game.setGameOver();
    }
}
