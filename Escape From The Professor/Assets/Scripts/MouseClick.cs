using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{

    // [SerializeField] private float[] Angle;
	
	public float properAngle;
	public float properAngleTwo;
	   
	public float smooth = 95.0f;

    [SerializeField]
    private float rotationStep = 90.0f;
    
    public bool position;

    private Quaternion targetRot;

    void Start()
    {
	    targetRot = transform.rotation;
    }


    void OnMouseDown()
    {

        transform.rotation = Quaternion.Euler(0,0, rotationStep) * transform.rotation;

    }
}
