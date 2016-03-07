#pragma strict

 
function OnTriggerEnter2D(other : Collider2D) //Check if something has entered the trigger ( and declares this object in "other" )
 {
    if(other.tag == "Player") //Checks if the Player is inside the trigger
    {
       Application.LoadLevel ( Application.loadedLevel);
    }
 }
