using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Transform targetPos;
    public bool isRange;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isRange)
        {
            GameManager.instance.transform.position = targetPos.position;
            Debug.Log("Entered the portal...");
        }
    }
    //void OnTriggerEnter2D(Collider2D collision)
    //{
        //if (collision.gameObject.tag == "Player") //check if player collides to an object
        //{
            //isRange = true;
            
        //}
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
        //if (collision.gameObject.tag == "Player") //check if player collides to an object
        //{
            //isRange = false;
        //}
    //}
}
