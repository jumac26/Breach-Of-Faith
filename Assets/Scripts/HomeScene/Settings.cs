using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
	public Button start;
	public Button settings;
	public Image image;
	public Text asd;
	
	public void SettingsButton()
	{
		
		start.enabled = false;
		settings.enabled = false;
		image.enabled = false;
		asd.text = "";
	}

	public void Update()
	{
		
	}

}
