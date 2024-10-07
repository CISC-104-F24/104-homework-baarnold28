using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{
    //Write your variables here:
    public string turtleName = "turtle 1" ;
    public float baseSpeed = 1.0F; 
    public Vector3 movementDirection = new Vector3(1f,0f,0f);
    public float distanceTraveled = 0f; 
    public float winningDistance = 20.4f; 
    public int votesReceived = 1;
    public float speedPerVote = 0.01f;
    public KeyCode voteKey; 


    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(turtleName + " is ready!"); 
    }

    // Update is called once per frame
    void Update()
    {
        bool isVoteKeyPressed = false; 
        isVoteKeyPressed = Input.GetKeyDown(KeyCode.G);
        if(isVoteKeyPressed)
        {
            votesReceived = votesReceived + 1;
        }

        float moveStep = (baseSpeed + votesReceived * speedPerVote) * Time.deltaTime;
        transform.position = transform.position + movementDirection * moveStep;
        distanceTraveled = distanceTraveled + moveStep;
        //Debug.Log(distanceTraveled);
        if(distanceTraveled > winningDistance)
        {
            Debug.LogWarning(turtleName + " has won"); 
        }
    }
}
