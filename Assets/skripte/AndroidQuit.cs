using UnityEngine;
using System.Collections;

public class AndroidQuit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Application.platform == RuntimePlatform.Android){
			if (Input.GetKeyDown(KeyCode.Escape)) 
				Application.Quit();
		}
	
	}
}
