using UnityEngine;
using System.Collections;

public class Respawnn1 : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			Application.LoadLevel ( Application.loadedLevel);
		}
	}
}


