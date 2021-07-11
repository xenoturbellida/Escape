using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escapeGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey("escape"))
		Application.Quit();
    }

}
