using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float yvalue = 0;
    [SerializeField] float moveSpeed = 5f;
    // [SerializeField] float zvalue = 0;
    void Start()
    {
        // transform.Translate(10,0,0);
        PrintInstructions();
    }


    void Update()
    {
        MovePlayer();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with W S A D");
        Debug.Log("Avoide the OBSTACLES");
    }
    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xvalue, yvalue, zvalue);
        // transform.Translate(xvalue, yvalue, zvalue);
    }
}
