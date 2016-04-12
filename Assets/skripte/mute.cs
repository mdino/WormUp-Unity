using UnityEngine;
using System.Collections;

public class mute : MonoBehaviour {

	
	public void MuteMusic () {
		if (GameObject.Find("GameMusic").GetComponent<AudioSource>().isPlaying) {          
			GameObject.Find("GameMusic").GetComponent<AudioSource>().Stop ();
				PlayerPrefs.SetInt("Music", 1);


		} else {            
			GameObject.Find("GameMusic").GetComponent<AudioSource>().Play ();
			PlayerPrefs.SetInt("Music", 0);
		
			
			}
		}
	}