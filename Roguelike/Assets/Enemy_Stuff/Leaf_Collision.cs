using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf_Collision : MonoBehaviour
{
    public GameObject leaf;
    public Collider2D leaf_collider;
    void OnCollisionEnter2D(Collision2D collide){ //If collision
            if (collide.gameObject.name=="Player" || collide.gameObject.name=="Obstacles"){ //If collision is an obstacle on map or player
                Destroy(leaf);
            }
        }
}   
