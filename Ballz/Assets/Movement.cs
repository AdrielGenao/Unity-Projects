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
    public int shots=1;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        if(shots==1){
            if (Input.GetMouseButtonUp(0)){
                playerPos.Rotate(0f,0f,-90f);
                shots-=1;
                Shoot();
            }
            if(Input.GetMouseButton(0)) //If mouse press
            {
                mouse = cam.ScreenToWorldPoint(Input.mousePosition); //Get mouse postion
                mouse = new Vector3(mouse.x,mouse.y,0f);
                playerPos.up=mouse-playerPos.position;              
                mouseDir.x=mouse.x+(playerPos.position.x-mouse.x)/2;
                mouseDir.y=mouse.y+(playerPos.position.y-mouse.y)/2;
                playerPos.Rotate(0f,0f,90f);
                distance=Vector3.Distance(playerPos.position,mouse);
                if (distance>3){
                    distance=3;
                }
                StartCoroutine(Waiting());
            }
        }
    void Shoot(){
        player.AddForce(playerPos.up*force,ForceMode2D.Impulse);
        }
    IEnumerator Waiting(){
        GameObject aiming=Instantiate(aim,mouseDir,playerPos.rotation);
        Vector3 scale=aiming.transform.localScale;
        scale.x=distance;
        aiming.transform.localScale=scale;
        yield return new WaitForSeconds(0.001f);
        Destroy(aiming);
        }
    }
}
