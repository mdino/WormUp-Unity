#pragma strict

private var ray : Ray;
private var hit: RaycastHit;

function Update(){
 
if (Input.touchCount == 1 ) {
	ray=Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
	if(Physics.Raycast(ray,hit)){
		if(hit.transform.name == "playgame"){
			GetComponent.<Renderer>().material.color = Color.grey;
			Application.LoadLevel("level1");
		
}
}
}
}

