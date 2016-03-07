using UnityEngine;
using System.Collections;



public class ChangeSceneScore : MonoBehaviour {

	public void ChangeToScene (){
		if (Score.highscore > 14) {
						Application.LoadLevel (Random.Range (3, 10));
				} 
		else 
						Application.LoadLevel ("level1");
		}



	/*public void ChangeToScene (string sceneToChangeTo){
		Application.LoadLevel (sceneToChangeTo);


}*/
}
