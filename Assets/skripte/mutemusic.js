#pragma strict

function SetGameVolumen () {
			if (GetComponent.<AudioSource>().mute)
                GetComponent.<AudioSource>().mute = false;
            else
                GetComponent.<AudioSource>().mute = true;
}