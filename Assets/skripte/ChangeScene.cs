using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;



public class ChangeScene : MonoBehaviour {

	public GameObject Lock2Reklama;
	public GameObject tekst;

	void Start(){
		Advertisement.Initialize ("93244");
		if (PlayerPrefs.GetInt ("XmasUnlocked") == 1 ) {
		
			Lock2Reklama.gameObject.SetActive(false);
			tekst.gameObject.SetActive(false);
		}
	}

 void Update(){
		//if (GameObject.Find ("GameObjectMusic(Clone)") == null && Application.loadedLevel != 0) {
			//Instantiate(Resources.Load("GameObjectMusic") as GameObject, transform.position, transform.rotation);
		//}	
	}

	
	public void ChangeToScene (string sceneToChangeTo){
		Application.LoadLevel (sceneToChangeTo);
	}

	public void Quit()
	{
		Application.Quit();
	}

	IEnumerator Loading(){
		yield return new WaitForSeconds (1.5f);
		//
		ShowOptions options = new ShowOptions();
		options.resultCallback = HandleShowResult;
		
		//if(Advertisement.isReady()){ 
		Advertisement.Show(null,options);
		//}
	}

	public void Reklame (){
		if (PlayerPrefs.GetInt ("XmasUnlocked") == 1) {
			Application.LoadLevel ("XmasLevel");
		}
		
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork
		    || Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
		{
			if (PlayerPrefs.GetInt ("XmasUnlocked") == 0) {
				StartCoroutine("Loading");
			}

		}
		else{
			GameObject.Find("Loading").SetActive(false);
		}
	}

	private void HandleShowResult (ShowResult result)
	{
		switch(result){
		case(ShowResult.Finished):
			PlayerPrefs.SetInt ("XmasUnlocked", 1);
			Application.LoadLevel ("XmasLevel");
			break;
			
		case(ShowResult.Failed):
			break;
			
		case(ShowResult.Skipped):
			break;
		}
	}
}