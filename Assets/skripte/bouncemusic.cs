using UnityEngine;
using System.Collections;

public class bouncemusic : MonoBehaviour {

	AudioClip[] Jumps;
	public AudioClip Jump;

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			GetComponent<AudioSource>().PlayOneShot(Jump);
		}
	}
}
