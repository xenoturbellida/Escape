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
    public int frame = 0;

    void Start()
    {
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (leftScript.properPos && centerScript.properPos && rightScript.properPos)
        {
            frame += 1;
            if (frame == 1)
            {
                startTime = Time.time;
            }
            LiftDoor();
        }
    }

    void LiftDoor()
    {
        distCovered = (Time.time - startTime) * speed;
        if (door.transform.position.y < endMarker.position.y)
        {
            float fractionOfJourney = distCovered / journeyLength;
            door.transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
        }
    }
}
