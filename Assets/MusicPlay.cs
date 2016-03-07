using UnityEngine;
using System.Collections;

public class MusicPlay : MonoBehaviour {


	public static bool create = false;

	// Use this for initialization
	void Awake () {
		if (!create) {
			DontDestroyOnLoad (this.gameObject);
			create = true;
		}
		else {
			if(this.gameObject.name != "GameObjectMusic(Clone)"){
				Destroy(this.gameObject);
			}

		}
	}
}
