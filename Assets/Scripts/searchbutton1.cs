using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class searchbutton : MonoBehaviour
{
    public bool searchstat, inrangeofplayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if(searchstat == true && inrangeofplayer == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void searchbut()
    {
        searchstat = true;
        Invoke("searchoff", 1f);
    }

    public void searchoff()
    {
        searchstat = false;
    }
        
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inrangeofplayer = true;
        }

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inrangeofplayer = false;
        }
    }


}
