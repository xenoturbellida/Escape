using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatuesPuzzle : MonoBehaviour
{
    public StatueRotation leftScript;
    public StatueRotation centerScript;
    public StatueRotation rightScript;

    public GameObject door;
    public Transform startMarker;
    public Transform endMarker;
    public float speed = 0.001f;
    public float startTime;
    public float journeyLength;

    public float distCovered;

    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    // Update is called once per frame
    void Update()
    {
        LiftDoor();
        if (leftScript.properPos && centerScript.properPos && rightScript.properPos)
        {
            Debug.Log("i am opened");
            // LiftDoor();
        }
    }

    void LiftDoor()
    {
        distCovered = (Time.time - startTime) * speed;
        if (distCovered < journeyLength)
        {
            Debug.Log(door.transform.position.y);
            Debug.Log(endMarker.position.y);
            float fractionOfJourney = distCovered / journeyLength;
            door.transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
        }
    }
}
