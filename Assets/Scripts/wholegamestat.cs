using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamestatscript : MonoBehaviour
{
    public int lvl1highscore, lvl2highscore, lvl3highscore, lvl4highscore, lvl5highscore;
    public int lvl1currentscore, lvl2currentscore, lvl3currentscore, lvl4currentscore, lvl5currentscore;
    public int lvl1hanoi, lvl1maze, lvl1quiz;
    public int lvl2hanoi, lvl2maze, lvl2quiz;
    public int lvl3hanoi, lvl3maze, lvl3quiz;
    public int lvl4hanoi, lvl4maze, lvl4quiz;
    public int lvl5hanoi, lvl5maze, lvl5quiz;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject a = GameObject.Find("gamestat");
        
        if (a != this.gameObject)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(a.gameObject);
        }
        PlayerPrefs.SetInt("lvl1highscore", lvl1highscore);
        PlayerPrefs.SetInt("lvl2highscore", lvl2highscore);
        PlayerPrefs.SetInt("lvl3highscore", lvl3highscore);
        PlayerPrefs.SetInt("lvl4highscore", lvl4highscore);
        PlayerPrefs.SetInt("lvl5highscore", lvl5highscore);

        if (lvl1currentscore > PlayerPrefs.GetInt("lvl1highscore"))
        {
            lvl1highscore = lvl1currentscore;
        }

        if (lvl2currentscore > PlayerPrefs.GetInt("lvl2highscore"))
        {
            lvl2highscore = lvl2currentscore;
        }

        if (lvl3currentscore > PlayerPrefs.GetInt("lvl3highscore"))
        {
            lvl3highscore = lvl3currentscore;
        }
        if (lvl4currentscore > PlayerPrefs.GetInt("lvl4highscore"))
        {
            lvl4highscore = lvl4currentscore;
        }
        if (lvl5currentscore > PlayerPrefs.GetInt("lvl5highscore"))
        {
            lvl5highscore = lvl5currentscore;
        }
    }

    public void startalevel()
    {
        lvl1currentscore = 0;
        lvl2currentscore = 0;
        lvl3currentscore = 0;
        lvl4currentscore = 0;
        lvl5currentscore = 0;
        lvl1hanoi = 0;
        lvl2hanoi = 0;
        lvl3hanoi = 0;
        lvl4hanoi = 0;
        lvl5hanoi = 0;
        lvl1maze = 0;
        lvl2maze = 0;
        lvl3maze = 0;
        lvl4maze = 0;
        lvl5maze = 0;
        lvl1quiz = 0;
        lvl2quiz = 0;
        lvl3quiz = 0;
        lvl4quiz = 0;
        lvl5quiz = 0;
    }

    public void endalevel()
    {
        lvl1currentscore = lvl1hanoi + lvl1maze + lvl1quiz;
        lvl2currentscore = lvl2hanoi + lvl2maze + lvl2quiz;
        lvl3currentscore = lvl3hanoi + lvl3maze + lvl3quiz;
        lvl4currentscore = lvl4hanoi + lvl4maze + lvl4quiz;
        lvl5currentscore = lvl5hanoi + lvl5maze + lvl5quiz;        
    }


}