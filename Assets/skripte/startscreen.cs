using UnityEngine;
using System.Collections;

public class startscreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1) {
						GetComponent<SpriteRenderer> ().enabled = false;
				} 
		else if (Input.GetKey ("right") || Input.GetKey ("d")) {
					GetComponent<SpriteRenderer> ().enabled = false;
						
				}
	}
}
