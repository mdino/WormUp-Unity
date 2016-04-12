using UnityEngine;
using System.Collections;

public class dontdesstti : MonoBehaviour {

	
	public static bool create = false;
	
	// Use this for initialization
	void Awake () {
		if (!create) {
			DontDestroyOnLoad (this.gameObject);
			this.gameObject.name = "Splash";
			create = true;
		}
		else {
			//if(this.gameObject.name != "Splash image"){
				Destroy(this.gameObject);
			//}
			
		}
	}

}
