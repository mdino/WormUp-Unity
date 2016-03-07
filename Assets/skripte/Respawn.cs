using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			GameObject.Find ("Canvas").gameObject.transform.FindChild ("HighScorepanel").gameObject.SetActive (true);
			GameObject.Find ("Player").gameObject.transform.FindChild ("Crash").gameObject.SetActive (true);
			GameObject.Find ("Player").gameObject.transform.
			FindChild ("Crash").gameObject.transform.SetParent (GameObject.Find ("Main Camera").transform);
			Destroy (GameObject.Find ("Player"), 0.1f);
		}
	}
}
