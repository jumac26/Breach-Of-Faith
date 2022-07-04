using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public bool search = false;

	public void LevelFive ()
	{
		SceneManager.LoadScene(7);
	}
	public void LevelFour()
	{
		SceneManager.LoadScene(6);
	}
	public void LevelThree()
	{
		SceneManager.LoadScene(5);
	}
	public void LevelTwo()
	{
		SceneManager.LoadScene(4);
	}
	public void LevelOne()
	{
		SceneManager.LoadScene(3);
	}
	public void LevelSelect ()
	{
		SceneManager.LoadScene(2);
	}
	public void Home ()
	{
		SceneManager.LoadScene(1);
	}
	public void Search ()
	{
		search = true;
	}
}
 