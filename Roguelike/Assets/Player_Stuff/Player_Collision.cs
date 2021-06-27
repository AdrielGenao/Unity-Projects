using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public int health = 0;
    public Collider2D Player_Collider;
    public SpriteRenderer spriteRenderer;
    public PlayerMovement pm;
 void OnCollisionEnter2D(Collision2D collide){ //If collision 
            if (collide.gameObject.name=="Enemy" || collide.gameObject.name=="Leaf(Clone)"){ //If hit by enemy or leaf
               StartCoroutine(Damage());
               health = health + 1;
               }
            }
 IEnumerator Damage(){
   for(int i = 0; i < 5; i++){ //Invincibility frames
   pm.moveSpeed = 6f; //Increase speed
   Player_Collider.enabled = false;
   spriteRenderer.enabled = false;
   yield return new WaitForSeconds(0.10f);
   spriteRenderer.enabled = true;
   yield return new WaitForSeconds(0.10f); //Turn off and on sprite
   }
   Player_Collider.enabled = true; //Turn collider back on
   pm.moveSpeed = 5f;
 }              
}
