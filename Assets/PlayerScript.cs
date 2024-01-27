using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;  // Speed of horizontal movement
    public float jumpForce = 10f; // Force applied when jumping
    public Rigidbody2D Rigiedbody2D; // Reference to the Rigidbody2D component  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        handleSideMovement();
        handleJumpMovement();
    }

    void handleSideMovement() {
        //move right
        if (Input.GetKey(KeyCode.D)) {
            Debug.Log("D pressed");
            float newPositionX = transform.position.x + (moveSpeed * Time.deltaTime);
            transform.position = new Vector2(newPositionX, transform.position.y);
        }

        //move left
        if (Input.GetKey(KeyCode.A)) {
            Debug.Log("A pressed");
            float newPositionX = transform.position.x - (moveSpeed * Time.deltaTime);
            transform.position = new Vector2(newPositionX, transform.position.y);
        }
    }

    void handleJumpMovement() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space pressed");
            Rigiedbody2D.velocity = new Vector2(Rigiedbody2D.velocity.x, jumpForce);
        }
    }
}
