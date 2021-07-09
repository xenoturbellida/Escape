using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipePuzzle : MonoBehaviour
{
	public MouseClick oneScript;
	public MouseClick twoScript;
	public MouseClick threeScript;
	public MouseClick fourScript;
	public MouseClick fiveScript;
	public MouseClick sixScript;
	public MouseClick sevenScript;
	public MouseClick eightScript;
	public MouseClick nineScript;
	public MouseClick tenScript;
	public MouseClick elevenScript;
	public MouseClick twelveScript;
	public MouseClick thirteenScript;
	public MouseClick fourteenScript;
	public MouseClick fifteenScript;

	public bool result;


	// Start is called before the first frame update
	public void NextLevel(int _sceneNumber)
	{
		SceneManager.LoadScene(_sceneNumber);
	}
	
    void Start()
    {
	    
    }

    // Update is called once per frame
    void Update()
    {
	    MouseClick[] Data = { oneScript, twoScript, fourScript, fiveScript, sixScript, sevenScript, 
		    eightScript, nineScript, tenScript, elevenScript};
	    
	    foreach (MouseClick i in Data)
	    {
		    if ((Quaternion.Angle(i.transform.rotation, Quaternion.Euler(0f, 0f, i.properAngle)) < 1f) || (Quaternion.Angle(i.transform.rotation, Quaternion.Euler(0f, 0f, i.properAngleTwo)) < 1f))
			    i.position = true;
		    else
		    {
			    i.position = false;
		    }

		    //result = result && i.position;
	    }

	    if (oneScript.position && twoScript.position && fourScript.position && fiveScript.position &&
	        sixScript.position && sevenScript.position && eightScript.position && nineScript.position &&
	        tenScript.position && elevenScript.position)
	    {
		    result = true;
		    NextLevel(1);

	    }

    }
}
