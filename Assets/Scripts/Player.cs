using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour { 

    public float moveSpeed = 10f;


    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        //Move
        Vector3 movement = new Vector3(moveX, 0f, moveY);
         
            
    }
}
