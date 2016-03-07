using UnityEngine;
using System.Collections;

public class GameAudio : MonoBehaviour
{
	public enum Trigger
	{
		OnClick
	}
	
	public Trigger trigger = Trigger.OnClick;
	private bool muted = false;
	
	void OnClick ()
	{        
		if (enabled && trigger == Trigger.OnClick)
		{
			if (!muted)
			{
				AudioListener.volume = 0.0f;
				muted = true;
			}
			else
			{
				AudioListener.volume = 1.0f;
				muted = false;
			}
		}
	}
}