using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Movement : MonoBehaviour
{
    public Vector3 mouse;
    public Rigidbody2D player;
    public float force=1f;
    public Camera cam;
    public Transform playerPos;
    public Vector3 mouseDir;
    public GameObject aim;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) //If mouse press
        {
            mouse = cam.ScreenToWorldPoint(Input.mousePosition); //Get mouse postion
            mouse= new Vector3(mouse.x,mouse.y,0f);
            mouseDir=mouse-playerPos.position;
            mouseDir.z=0.0f;
            mouseDir=mouseDir.normalized;
            playerPos.up=mouse-playerPos.position;              
            mouseDir.x=mouse.x+(playerPos.position.x-mouse.x)/2;
            mouseDir.y=mouse.y+(playerPos.position.y-mouse.y)/2;
            playerPos.Rotate(0f,0f,90f);
            StartCoroutine(Waiting());
        }
    }
    void Shoot(){
        player.AddForce(mouseDir*force,ForceMode2D.Impulse);
    }
    IEnumerator Waiting(){
        GameObject aiming=Instantiate(aim,mouseDir,playerPos.rotation);
        yield return new WaitForSeconds(0.001f);
        Destroy(aiming);
    }
}
