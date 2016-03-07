using UnityEngine;
using System.Collections;

public class touch2d : MonoBehaviour {

	public float movementSpeed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount == 1 ) {
			transform.position -= Vector3.left * movementSpeed * Time.deltaTime;
			GameObject.Find("Player").GetComponent<Animator>().SetTrigger("Star t");
		}

		else if (Application.platform == RuntimePlatform.Android){
				if (Input.GetKeyDown(KeyCode.Escape)) 
					Application.Quit();
			}


		}

}

