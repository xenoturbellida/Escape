using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public int _sceneNumber;
    public Button playButton;
    public AudioSource clickSound;
    
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        clickSound.Play();
        SceneManager.LoadScene(_sceneNumber);
    }
}
