using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Player_Collision pc;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    // Update is called once per frame
    void Update()
    {
        if(pc.health == 1){
            Destroy(heart1);
        }
        if(pc.health == 2){
            Destroy(heart2);
        }
        if(pc.health == 3){
            Destroy(heart3);
        }
    }
}
