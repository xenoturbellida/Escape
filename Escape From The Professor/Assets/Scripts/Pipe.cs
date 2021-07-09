using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public bool isRotated;

    public GameObject _person;
    public GameObject _camera;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotated && Input.GetKeyDown(KeyCode.F))
        {
            _camera.SetActive(true);
            _person.SetActive(false);
            //ch_camera.enabled = !ch_camera.enabled;
            //_camera.enabled = !_camera.enabled;
            //Debug.Log("Yes");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        isRotated = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isRotated = false;
    }
}
