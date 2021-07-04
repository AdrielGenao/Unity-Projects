using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Collider2D col;
    public GameObject target;
    void OnCollisionEnter2D(Collision2D collide){ //If collision
            if(collide.gameObject.name=="Player"){ //If collision is an obstacle on map or enemy
                Destroy(target);
}
    }
}
