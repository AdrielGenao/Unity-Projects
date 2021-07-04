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
        for(int a=0;a<=4;a++){
        enemySpawn=new Vector3(player.position.x+Random.Range(1f,4.5f),player.position.y+Random.Range(1f,2.5f),0f);
        GameObject target=Instantiate(enemy,enemySpawn,targetrot.rotation);
        spawns.Add(enemySpawn.x);
        if(a>0){
            for(int i=0;i<a;i++){
                if((Mathf.Abs(spawns[i]-enemySpawn.x)<=1f)){
                    spawns.RemoveAt(a);
                    Destroy(target);
                    a--;
                    break;
                }
            }
        }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
