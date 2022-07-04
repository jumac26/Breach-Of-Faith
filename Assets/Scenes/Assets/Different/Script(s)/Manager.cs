using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject set1, set2, set3, set4, set5, set6, score0, score1, score2, score3, score4, score5, score6, scoreimage;
    public float setnumber = 1f;
    public float score = 0f;
    public GameObject button1, button2, button3, button4, question;
    public GameObject basequestion, text1, text2, text3, text4, text5, text6;
    public GameObject showscore, proceed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextset()
    {
        if (setnumber == 1)
        {
            Invoke("replacequestion", 0);
            text1.SetActive(true);
            Invoke("insertquestion", 2f);
            set1.SetActive(false);
            Invoke("shift1", 2f);
            Invoke("addsetnumber", 0.2f);
            
            
        }
        if (setnumber == 2)
        {
            Invoke("replacequestion", 0);
            text2.SetActive(true);
            Invoke("insertquestion", 2f);
            set2.SetActive(false);
            Invoke("shift2", 2f);
            Invoke("addsetnumber", 0.2f);
        }
        if (setnumber == 3)
        {
            Invoke("replacequestion", 0);
            text3.SetActive(true);
            Invoke("insertquestion", 2f);
            set3.SetActive(false);
            Invoke("shift3", 2f);
            Invoke("addsetnumber", 0.2f);
        }
        if (setnumber == 4)
        {
            Invoke("replacequestion", 0);
            text4.SetActive(true);
            Invoke("insertquestion", 2f);
            set4.SetActive(false);
            Invoke("shift4", 2f);
            Invoke("addsetnumber", 0.2f);
        }
        if (setnumber == 5)
        {
            Invoke("replacequestion", 0);
            text5.SetActive(true);
            Invoke("insertquestion", 2f);
            set5.SetActive(false);
            Invoke("shift5", 2f);
            Invoke("addsetnumber", 0.2f);
        }
        if (setnumber == 6)
        {
            Invoke("replacequestion", 0);
            text6.SetActive(true);
            Invoke("insertquestion", 2f);
            set6.SetActive(false);
            Invoke("addsetnumber", 0.2f);
            Invoke("show", 0.2f);
            

            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
            question.SetActive(false);
            Invoke("closescore", 20);
        }
        if (setnumber == 7)
        {
            scoreimage.SetActive(true);
            if (score == 0)
            {
                score0.SetActive(true);

            }
            if (score == 1)
            {
                score1.SetActive(true);
            }
            if (score == 2)
            {
                score2.SetActive(true);
            }
            if (score == 3)
            {
                score3.SetActive(true);
            }
            if (score == 4)
            {
                score4.SetActive(true);
            }
            if (score == 5)
            {
                score5.SetActive(true);
            }
            if (score == 6)
            {
                score6.SetActive(true);
            }
            showscore.SetActive(false);
            

        }
    }
    public void addsetnumber()
    {
        setnumber++;
    }

    public void closescore()
    {
        score0.SetActive(false);
        score1.SetActive(false);
        score2.SetActive(false);
        score3.SetActive(false);
        score4.SetActive(false);
        score5.SetActive(false);
        score6.SetActive(false);
        scoreimage.SetActive(false);
    }

    public void replacequestion()
    {
        basequestion.SetActive(false);
    }

    public void insertquestion()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
        basequestion.SetActive(true);
    }

    public void shift1()
    {
        set2.SetActive(true);
    }
    public void shift2()
    {
        set3.SetActive(true);
    }
    public void shift3()
    {
        set4.SetActive(true);
    }
    public void shift4()
    {
        set5.SetActive(true);
    }
    public void shift5()
    {
        set6.SetActive(true);
    }

    public void question1()
    {
        if (setnumber == 1)
        {
            score++;
        }
    }
    public void question2()
    {
        if (setnumber == 2)
        {
            score++;
        }
    }
    public void question3()
    {
        if (setnumber == 3)
        {
            score++;
        }
    }
    public void question4()
    {
        if (setnumber == 4)
        {
            score++;
        }
    }
    public void question5()
    {
        if (setnumber == 5)
        {
            score++;
        }
    }
    public void question6()
    {
        if (setnumber == 6)
        {
            score++;
        }
    }

    public void show()
    {
        showscore.SetActive(true);
        proceed.SetActive(true);
    }

    public void proceedbutton()
    {

    }



}
