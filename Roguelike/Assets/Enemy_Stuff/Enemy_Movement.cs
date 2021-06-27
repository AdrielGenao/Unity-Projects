using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public Transform Player;
    public Transform Enemy;
    public float distance;
    public float moveSpeed;
    public Animator animator;
    public float direction;
    public Vector2 coordinate;
    public float angle;
    public bool visible;
    
    void Update()
    { 
        distance = Vector2.Distance(Enemy.position, Player.position); //Distance between player and enemy
        if(distance <= 10){
        visible = true; //Player is visible
        animator.SetBool("Visible", visible);
        }
        if(visible == true){
        coordinate = -Player.position + Enemy.position; //Coordinate for angle equation
        angle = Mathf.Atan2(coordinate.y, coordinate.x); //Find angle to determine animation for enemy
        animator.SetFloat("Angle", angle);
        if(coordinate.x >= -2 && coordinate.x <= 2 && coordinate.y >= 1){
            direction = 4; //Down
        }
        if(coordinate.x >= -2 && coordinate.x <= 2 && coordinate.y <= -1){
            direction = 2; //Up
        }
        if(coordinate.y >= -2 && coordinate.y <= 2 && coordinate.x >= 1){
            direction = 3; //Left
        }
        if(coordinate.y >= -2 && coordinate.y <= 2 && coordinate.x <= -1){
            direction = 1; //Right
        }
        Enemy.position = Vector2.MoveTowards(Enemy.position, Player.position, moveSpeed*Time.deltaTime); //Go towards player
        animator.SetFloat("Direction", direction);
        }
        if(distance > 10){ //If Player is too far
            visible = false;
            animator.SetBool("Visible", visible);
        }
    
}
}
