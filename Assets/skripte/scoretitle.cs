using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoretitle : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	

	void Update() {

		GetComponent<Text>().text = " " + Score.score;
		} 


}
