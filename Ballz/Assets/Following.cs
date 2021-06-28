using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour
{
    public Transform player;
    public Transform cam;

    // Update is called once per frame
    void Update()
    {
        cam.position=new Vector3(player.position.x,player.position.y,-10);
    }
}
