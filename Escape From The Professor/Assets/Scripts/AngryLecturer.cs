using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryLecturer : MonoBehaviour
{
    private Animator ch_animator;

    private AudioSource audio;
    // Use this for initialization
    void Start () 
    {
        ch_animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }
	
    // Update is called once per frame
    void Update () {
	
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            ch_animator.SetBool("move", true);
            audio.Play();
        }
    }
}
