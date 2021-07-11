using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CameraScene : MonoBehaviour
{
	public GameObject _camera;
	public GameObject _audio;
	public VideoPlayer texture;

	public bool play = false;

	void Start(){
		texture.Play();
	}

	void Update()
	{
		if (texture.isPlaying){
			play = true;
			GetComponent<AudioSource>().Play();


		}
		if (!texture.isPlaying && play){
			 _camera.SetActive(false);
		}
		// if (texture.isPlaying) GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), texture);
		// else {
		// 	Debug.Log("Playing Video");
		// }
	}
}
