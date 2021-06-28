using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Right;
    public Transform Left;
    public Transform Bottom;
    public Transform Top;
    public GameObject arrowPrefab;
    public float arrowForce = 20f;
    public PlayerMovement pm;
    public Vector3 mouse;

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) //If mouse press
        {
            mouse = pm.cam.ScreenToWorldPoint(Input.mousePosition); //Get mouse postion
            mouse = new Vector3(mouse.x, mouse.y, 0f); //Create 2D mouse position
            Shoot();
        }
    }

    void Shoot() //Shooting Function
    {
        //if statement is to make sure player cant shoot itself
        if(pm.direction == 1 && mouse.x >= Right.position.x){ //Shooting towards right direction
            Right.up = mouse - Right.position;
            GameObject arrow = Instantiate(arrowPrefab, Right.position, Right.rotation);
            Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
            rb.AddForce(Right.up * arrowForce, ForceMode2D.Impulse);
        }
        if(pm.direction == 2 && mouse.x <= Left.position.x){ //Shooting towards left direction
            Left.up = mouse - Left.position;
            GameObject arrow = Instantiate(arrowPrefab, Left.position, Left.rotation);
            Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
            rb.AddForce(Left.up * arrowForce, ForceMode2D.Impulse);
        }
        if(pm.direction == 3 && mouse.y >= Top.position.y){ //Shooting towards top direction
            Top.up = mouse - Top.position;
            GameObject arrow = Instantiate(arrowPrefab, Top.position, Top.rotation);
            Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
            rb.AddForce(Top.up * arrowForce, ForceMode2D.Impulse);
        }
        if(pm.direction == 4 && mouse.y <= Bottom.position.y){ //Shooting towards bottom direction
            Bottom.up = mouse - Bottom.position;
            GameObject arrow = Instantiate(arrowPrefab, Bottom.position, Bottom.rotation);
            Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
            rb.AddForce(Bottom.up * arrowForce, ForceMode2D.Impulse);
        }
        
        

    }
}
