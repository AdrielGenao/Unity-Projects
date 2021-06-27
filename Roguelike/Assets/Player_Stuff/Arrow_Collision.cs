using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Collision : MonoBehaviour
{
    public GameObject arrow;
    public Collider2D arrow_collider;
    void OnCollisionEnter2D(Collision2D collide){ //If collision
            if(collide.gameObject.name=="Enemy" || collide.gameObject.name=="Obstacles"){ //If collision is an obstacle on map or enemy
                Destroy(arrow);
            }
        }
    }
   

