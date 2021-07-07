using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatuesPuzzle : MonoBehaviour
{
    public StatueRotation leftScript;
    public StatueRotation centerScript;
    public StatueRotation rightScript;
    
    // Update is called once per frame
    void Update()
    {
        if (leftScript.properPos && centerScript.properPos && rightScript.properPos)
        {
            Debug.Log("The puzzle with statues was solved.");
        }
    }
}
