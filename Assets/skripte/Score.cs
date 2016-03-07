using UnityEngine;
using System.Collections;

public class Score: MonoBehaviour {

	public static int score=0;
	public static int highscore=0;
	public static int tempscore=0;
	
	static public void AddPoint(){
		
		score++;
		tempscore = score;
		
		if (score > highscore) {
			highscore=score;
		}
	}
	
	void Start() {
		score = 0;
		highscore = PlayerPrefs.GetInt ("highscore", 0);
		tempscore = PlayerPrefs.GetInt ("tempscore", 0);
		
		
	}
	void OnDestroy(){
		PlayerPrefs.SetInt ("highscore", highscore);
		PlayerPrefs.SetInt ("tempscore", tempscore);
		
	}


	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1) {
			GetComponent<GUIText>().text = " " + score; 
		} 
		else if (Input.GetKey ("right") || Input.GetKey ("d")) {
			GetComponent<GUIText>().text = " " + score; 
		}

	}
}
