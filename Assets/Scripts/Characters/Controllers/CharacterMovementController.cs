using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    private Rigidbody rb;
         
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Movement(Vector2 dir) 
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        Vector3 movement = new Vector3(dir.x, 0, dir.y);

        rb.AddForce(movement);
    }
}


