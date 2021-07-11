using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftDoorAfterNote : MonoBehaviour
{
    // public Note note;
    public GameObject door;
    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1f;
    public float startTime;
    public float journeyLength;
    public float distCovered;
    public int frame = 0;
    private AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        audio = door.GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Note>().wasRead)
        {
            frame += 1;
            if (frame == 1)
            {
                startTime = Time.time;
                audio.Play();
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
