using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shooting : MonoBehaviour
{
    public GameObject leafPrefab;
    public Transform Top;
    public Transform Bottom;
    public Transform Left;
    public Transform Right;
    public float leafForce = 10f;
    public Enemy_Movement em;
    public Vector3 Player;
    public Enemy_Collision ec;
    void Start(){
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot(){
        yield return new WaitForSeconds(1f);
        if (em.visible == true && ec.hit <= 1){
            GameObject leaf;
            Rigidbody2D rb;
            Player = new Vector3(em.Player.position.x, em.Player.position.y, 0f); 
            switch(em.direction){
                case 1:
                    Right.up = Player - Right.position;
                    leaf = Instantiate(leafPrefab, Right.position, Right.rotation);
                    rb = leaf.GetComponent<Rigidbody2D>();
                    rb.AddForce(Right.up * leafForce, ForceMode2D.Impulse);
                    break;
                case 2:
                    Top.up = Player - Top.position;
                    leaf = Instantiate(leafPrefab, Top.position, Top.rotation);
                    rb = leaf.GetComponent<Rigidbody2D>();
                    rb.AddForce(Top.up * leafForce, ForceMode2D.Impulse);
                    break;
                case 3:
                    Left.up = Player - Left.position;
                    leaf = Instantiate(leafPrefab, Left.position, Left.rotation);
                    rb = leaf.GetComponent<Rigidbody2D>();
                    rb.AddForce(Left.up * leafForce, ForceMode2D.Impulse);
                    break;
                case 4:
                    Bottom.up = Player - Bottom.position;
                    leaf = Instantiate(leafPrefab, Bottom.position, Bottom.rotation);
                    rb = leaf.GetComponent<Rigidbody2D>();
                    rb.AddForce(Bottom.up * leafForce, ForceMode2D.Impulse);
                    break;
            }
        }
        StartCoroutine(Shoot());
    }
}
