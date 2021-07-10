using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public bool isRotated;

    public GameObject _person;
    public GameObject _camera;

    public GameObject prompt;
    
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
            prompt.SetActive(false);

        }

        if (isRotated && Input.GetKeyDown(KeyCode.Escape))
        {
            _camera.SetActive(false);
            _person.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        isRotated = true;
        prompt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        isRotated = false;
        prompt.SetActive(false);
    }
}
