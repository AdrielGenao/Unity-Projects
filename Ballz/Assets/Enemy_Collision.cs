using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collision : MonoBehaviour
{
    public GameObject target;
    public Collider2D col;
    public Rigidbody2D player;
    public Transform player_pos;
    public float force=20f;
    public Movement movement;
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collide){ //If collision
            if(collide.gameObject.name=="Player"){ //If collision is an obstacle on map or enemy
                player.AddForce(player_pos.up*force,ForceMode2D.Impulse);
                movement.shots+=1;
                Destroy(target);
            }
        }
}
