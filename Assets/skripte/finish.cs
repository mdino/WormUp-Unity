using UnityEngine;
using System.Collections;

public class finish : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			Score.highscore=999;

		}
	}
}
