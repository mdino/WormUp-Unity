using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoretitle1 : MonoBehaviour {


	void Update() {
			GetComponent<Text>().text = " " + Score.highscore;
		} 
}
