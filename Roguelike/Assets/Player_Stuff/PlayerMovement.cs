using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Vector2 movement;
    public Animator animator;
    public bool mouse;
    public int direction;
    public Camera cam;
    public Vector2 mousePos;
    public Vector2 lookPos;
    public float angle;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // Get x movement
        movement.y = Input.GetAxisRaw("Vertical"); // Get y movement
        mouse = Input.GetMouseButton(0); // Get Click
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if(-1 < angle && angle <= 1){
            direction = 1; // Right
        }
        if(2 < angle && angle <= 3.5){
            direction = 2; // Left
        }
        if(-3.5 < angle && angle <= -2){
            direction = 2; // Left
        }
        if(1 < angle && angle <= 2){
            direction = 3; // Up
        }
        if(-2 < angle && angle <= -1){
            direction = 4; // Down
        }

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        animator.SetInteger("Direction", direction);
        animator.SetFloat("Angle", angle);
        animator.SetBool("Mouse", mouse);


    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position+movement*moveSpeed*Time.fixedDeltaTime); //Move Player to position
        lookPos = mousePos - rb.position;
        angle = Mathf.Atan2(lookPos.y, lookPos.x); //Make angle
    }
}
