using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Generation : MonoBehaviour
{
    public Transform player;
    public GameObject enemy;
    public Vector3 enemySpawn;
    public List<float> spawns;
    public Transform targetrot;

    void Start()
    {
        for(int a=0;a<=3;a++){
        enemySpawn=new Vector3(player.position.x+Random.Range(1.5f,4.5f),player.position.y+Random.Range(1.5f,2.5f),0f);
        spawns.Add(enemySpawn.x);
        if(a>0){
            if((Mathf.Abs(spawns[a-1]-enemySpawn.x)<=0.5f)){
                spawns.RemoveAt(a);
                a--;
            }
        }
        GameObject target=Instantiate(enemy,enemySpawn,targetrot.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
