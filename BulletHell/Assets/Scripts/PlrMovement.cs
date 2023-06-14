using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlrMovement : MonoBehaviour
{
    public float moveSpeedconst = 7f;
    float moveSpeed = 7f;
    public Rigidbody2D Rb;
    Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = 2f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed =  moveSpeedconst;
        }
    }
    void FixedUpdate()
    {
        Rb.MovePosition(Rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
