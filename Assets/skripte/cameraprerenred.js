#pragma strict
var target : Transform;

	function OnPreRender () {
		if(GameObject.Find("Player") != null)
		transform.position.x = target.position.x;
	}