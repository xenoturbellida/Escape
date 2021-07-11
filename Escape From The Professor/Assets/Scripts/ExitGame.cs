using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public Button exitButton;
    public AudioSource clickSound;
    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        clickSound.Play();
        Application.Quit();
    }
}
