using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(LoadMainScreen());
    }

    void Update()
    {
        
    }

    IEnumerator LoadMainScreen()
    {
        yield return new WaitForSeconds(11.30f);
        SceneManager.LoadScene("HomeScreen");

    }
}
