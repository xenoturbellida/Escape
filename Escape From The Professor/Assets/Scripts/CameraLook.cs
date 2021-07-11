using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public bool isRotated;

    public GameObject _person;
    public GameObject _camera;
    public GameObject _menu;
    
    // Start is called before the first frame update
    void Start()
    {
        _menu.SetActive(false);
        _camera.SetActive(false);
    }

    // Update is called once per frame
    //void Update()
    //{
        //if (isRotated)
        //{
            //_camera.SetActive(true);
          //  _person.SetActive(false);

        //}

        //if (isRotated)
        //{
          //  _camera.SetActive(false);
        //    _person.SetActive(true);
      //  }
    //}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            _menu.SetActive(true);
            _camera.SetActive(true);
            _person.SetActive(false);
           // ch_animator.SetBool("move", true);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
      //  isRotated = true;
    //}

   // private void OnTriggerExit(Collider other)
    //{
      //  isRotated = false;
    //}
}