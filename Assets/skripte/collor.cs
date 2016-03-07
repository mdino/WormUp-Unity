using UnityEngine;
using System.Collections;

public class collor : MonoBehaviour {
	
		public float timer = 0.0f;
		
		void Start () 
		{
			
		}
		
		
		void Update () 
		{
			timer += Time.deltaTime;
			if (timer >= 2.0f)//change the float value here to change how long it takes to switch.
			{
				// pick a random color
				Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
				// apply it on current object's material
				GetComponent<Renderer>().material.color = newColor;
				timer = 0;
			}
			
			
		}
	}