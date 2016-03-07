using UnityEngine;
using System.Collections;

public class tekstura : MonoBehaviour {

	void Start(){
	
				GetComponent<GUITexture>().enabled = false;
		}
	
void Update () {

	if (Input.touchCount == 1) {

						GetComponent<GUITexture>().enabled = true;

				} 
	else if (Input.GetKey ("right") || Input.GetKey ("d")) {

						GetComponent<GUITexture>().enabled = true;
				}

}
}
