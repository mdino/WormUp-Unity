using UnityEngine;
using System.Collections;

public class ParticleSortingLayer : MonoBehaviour {
	
	void Start ()
	{
		// Set the sorting layer of the particle system.
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "foreground";
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingOrder = -2;
	}
}