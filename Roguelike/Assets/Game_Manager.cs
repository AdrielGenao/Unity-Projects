using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Game_Manager : MonoBehaviour {

    public bool endgame = false;
    public Player_Collision pc;
    public GameObject Player;
    public GameObject canvas;
    public Button button;
    void Update()
    {
        if(pc.health == 3 && endgame == false){
        Destroy(Player);
        endgame = true;
        Debug.Log("Game Over");
        GameObject newCanvas = Instantiate(canvas) as GameObject;
        Button btn = newCanvas.transform.Find("Button").GetComponent<Button>();
		btn.onClick.AddListener(Restart);
        }
    }
    void Restart(){
        SceneManager.LoadScene("Main");
    } 
}

