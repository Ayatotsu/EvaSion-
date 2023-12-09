using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinished : MonoBehaviour
{

    public GameManager gameManager;

    [Header("Panels")]
    public GameObject objCanvas;
    public GameObject panelGameOver;

    [Header("GameElements")]
    public GameObject gameElements;
    public GameObject player;
    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        objCanvas = GameObject.Find("Canvas").gameObject;
        panelGameOver = objCanvas.transform.Find("GameOver").gameObject;
        gameElements = GameObject.Find("GameElements").gameObject;
        player = gameElements.transform.Find("Biker_idle_0").gameObject;
        obstacle = gameElements.transform.Find("Obstacle").gameObject;

    }

    private void OnCollisionEnter2D(Collision2D actor)
    {
        panelGameOver.gameObject.SetActive(true);
        player.gameObject.SetActive(false);
        obstacle.gameObject.SetActive(false);
        
        Debug.Log("GAME OVER!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
