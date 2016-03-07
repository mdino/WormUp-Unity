#pragma strict

static var AudioBegin    : boolean = false;
            
 function Awake()
 {
     if (!AudioBegin)
     {
         GetComponent.<AudioSource>().Play();
         DontDestroyOnLoad(gameObject);
         AudioBegin = true;
     }
     
     else if (AudioBegin)
     {
         GetComponent.<AudioSource>().Play();
         DontDestroyOnLoad(gameObject);
         AudioBegin = false;
     }
     
    
 }