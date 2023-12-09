using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinished : MonoBehaviour
{

    public GameManager gameManager;

    public GameObject objCanvas;
    public GameObject panelGameOver;
    public GameObject panelGameFinished;

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
        panelGameFinished = objCanvas.transform.Find("GameFinished").gameObject;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //yeah boi
        if (collision.gameObject.tag == "Player") //check if player collides to an object
        {
            panelGameOver.gameObject.SetActive(true);
            player.gameObject.SetActive(false);
            obstacle.gameObject.SetActive(false);

        }
    void OntriggerEnter2D(Collider2D actor)
    {
            if (actor.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.W))
            {
                panelGameFinished.gameObject.SetActive(true);
                player.gameObject.SetActive(false);
                obstacle.gameObject.SetActive(false);
            }
        }

        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
