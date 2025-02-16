using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
// Turret looking at the target
{
    [SerializeField] Transform target;
    Vector2 lastRotation;
    
    // Update is called once per frame
    void Update()
    {
        // in 2D games the following line will not work properly, so we have to create an offset
        // gameObject.transform.LookAt(target);
        Vector2 direction = target.position - transform.position;
        // in order to make the turret update direction when we move only (change offset)
        if(lastRotation != direction)
        {
            // Vector3.up = new Vector3(0, 1, 0)
            transform.rotation = Quanterion.FromToRotation(Vector3.up, direction);
            Debug.Log("test");
        }
        lastRotation = direction;
        
        
    }

}
