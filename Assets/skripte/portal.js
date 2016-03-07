#pragma strict

var target : GameObject;
var adjust : float;

function Start () {

}

function Update () {

}

function OnTriggerEnter(other : Collider){
	if(other.tag == "Player"){
		other.gameObject.transform.position = Vector3(target.transform.position.x, target.transform.position.y + adjust, 0);
	
	}

}