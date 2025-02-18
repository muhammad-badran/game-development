using NUnit.Framework.Constraints;
using UnityEngine;

// RigidBody2D based movement is used although it is better to use transform-based method
public class PlayerController : MonoBehaviour
{
    public bool _disableMovement = false;

    // Our Component
    Rigidbody2D _rb; // Create the container for or RigidBody2D

    // Our fields related to movement
    float _moveHorizontal; // Get horizonal input
    float _moveSpeed = 60f; // Out movespeed

    void Start()
    {
        // Assign the RigidBody2D to our container
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Assign the player input
        _moveHorizontal = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        // Assign the player input
        if (!_disableMovement)
        {
            MovePlayer();
        }
    }

    // Create the method for player movement
    void MovePlayer()
    {
        if (_moveHorizontal != 0) // Check or player input
        {
            _rb.AddForce(new Vector2(_moveHorizontal * _moveSpeed, 0f));
        }

    }
}
