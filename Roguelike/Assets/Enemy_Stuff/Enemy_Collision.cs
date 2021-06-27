using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collision : MonoBehaviour
{
    public GameObject enemy;
    public int hit;
    public Animator Enemy_animator;
    public SpriteRenderer rend;
    public Color color;
    public Enemy_Movement em;
    public Rigidbody2D rb;
    
    void OnCollisionEnter2D(Collision2D collide){ //If collision 
            if (collide.gameObject.name=="arrow(Clone)"){ //If object collided with is a projectile
               hit = hit + 1;
               Enemy_animator.SetInteger("Hit", hit);
               if(hit <= 1){ //As long as the enem has not been hit or only hit once
               StartCoroutine(Damage());
               }
            }
        }          
    IEnumerator Damage(){ //Hit change color
        color = Color.red;
        rend.color = color; //Set sprite color to red (Indicates enemy has been hit)
        rb.AddForce(em.coordinate * 10, ForceMode2D.Impulse); //Knockback
        yield return new WaitForSeconds(0.25f); //Wait a quarter of a second
        color = Color.white;
        rend.color = color; //Set sprite renderer back to normal;

    }    
 
}
