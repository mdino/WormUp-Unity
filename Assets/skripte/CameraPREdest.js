#pragma strict
var target : Transform;
var dest : float = 1.0;

	function OnPreRender () {
		
		transform.position.x = target.position.x + dest;
	}