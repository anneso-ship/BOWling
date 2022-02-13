using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame : MonoBehaviour
{
    public int firstscore;
    public int secondscore;
    public int thiredscore = 0;

    public Frame(int firstscore, int secondscore, int thiredscore)
    {
        this.firstscore = firstscore;
        this.secondscore = secondscore;
        this.thiredscore = thiredscore;
    }

    public int getFirstscore()
    {
        return firstscore;
    }
    public void setFirstscore(int firstscore)
    {
        this.firstscore = firstscore;
    }
    public int getSecondscore()
    {
        return secondscore;
    }

    public void setSecondscore(int secondscore)
    {
        this.secondscore = secondscore;
    }
    public int getThiredscore()
    {
        return thiredscore;
    }
    public void setThiredscore(int thiredscore)
    {
        this.thiredscore = thiredscore;
    }
   
}
