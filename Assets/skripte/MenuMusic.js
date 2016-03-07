
#pragma strict

function MuteMusic() {
    // see if we've got game music still playing
    var gameMusic : GameObject = GameObject.Find("GameMusic");
        Destroy(gameMusic);
        
}