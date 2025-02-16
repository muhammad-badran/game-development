using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    float _moveSpeed = 10f;
    float _rotateSpeed = 200f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // we can omit gameObject.
            // Time.deltaTime: to adjust the frame rate for different pcs
            // Space.World: to change the motion prespective from the self (player) to the world
            gameObject.transform.Translate(new Vector2(0f, _moveSpeed) * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, _rotateSpeed) * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, -_rotateSpeed) * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(new Vector2(0f, -_moveSpeed) * Time.deltaTime, Space.Self);
        }
    }

}