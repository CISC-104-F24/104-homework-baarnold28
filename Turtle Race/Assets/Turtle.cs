using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{
    //Write your variables here:
    public string turtleName = "turtle 1" ;
    public float baseSpeed = 1.0F; 
    public Vector3 movementDirection = new Vector3(1f,0f,0f);


    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(turtleName + " is ready!"); 
    }

    // Update is called once per frame
    void Update()
    {
        float moveStep = baseSpeed * Time.deltaTime;
        transform.position = transform.position + movementDirection * moveStep;
    }
}
