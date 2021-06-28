using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 mouse;
    public Rigidbody2D player;
    public float force=1f;
    public Camera cam;
    public Transform playerPos;
    public Vector3 mouseDir;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) //If mouse press
        {
            mouse = cam.ScreenToWorldPoint(Input.mousePosition); //Get mouse postion
            mouseDir=mouse-playerPos.position;
            mouseDir.z=0.0f;
            mouseDir=mouseDir.normalized;
            Shoot();
        }
    }
    void Shoot(){
        player.AddForce(mouseDir*force,ForceMode2D.Impulse);
    }
}
