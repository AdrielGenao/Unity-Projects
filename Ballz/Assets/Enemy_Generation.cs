using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Generation : MonoBehaviour
{
    public Transform player;
    public GameObject enemy;
    public Transform targetrot;

    void Start()
    {   
        for(int b=0;b<=5;b++){
            GameObject target=Instantiate(enemy,new Vector3(player.position.x+Random.Range(1f,5f),player.position.y+Random.Range(1f,2.5f),0f),targetrot.rotation);        
        }
        for(int b=0;b<=50;b++){
            GameObject target=Instantiate(enemy,new Vector3(player.position.x+Random.Range(1f,20f),player.position.y+Random.Range(1f,10f),0f),targetrot.rotation);        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
