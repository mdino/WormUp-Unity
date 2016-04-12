using UnityEngine;
using System.Collections;

public class musicChange : MonoBehaviour {

	public AudioClip Music1;
	// Use this for initialization
	void Start () {
		if(GameObject.Find ("GameMusic") != null){
			GameObject.Find ("GameMusic").GetComponent<AudioSource> ().clip = Music1;
			GameObject.Find("GameMusic").GetComponent<AudioSource>().enabled = false;
			GameObject.Find("GameMusic").GetComponent<AudioSource>().enabled = true;

			if(PlayerPrefs.GetInt("Music") == 1){
				GameObject.Find("GameMusic").GetComponent<AudioSource>().Stop ();
			}else{
				GameObject.Find("GameMusic").GetComponent<AudioSource>().Play ();
			}
		}
	}
}
