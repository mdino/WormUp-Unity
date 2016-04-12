using UnityEngine;
using System.Collections;

public class mutepicture : MonoBehaviour {

	public GameObject slika;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("Music") == 0) {
			slika.gameObject.SetActive(true);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
