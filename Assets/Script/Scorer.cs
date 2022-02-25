using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public int[] frameRes = new int [21] ;
    public balle Ball;
    public Text score;
    public Text[] scores_text;
    public Text[] scores_frame;
    int totalScore;
    Frame[] frames = new Frame[10];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void ScoreDisplay(int a, int b, int c, int i,int d)
    {
        /*
            a ==> numéro de lancé
            b ==> nombre de quilles renversé lors du premier lancé du frame courant
            c ==> nombre de quilles renversé lors du deuxième lancé du frame courant
            d ==> nombre de quilles renversé lors du troisième lancé du frame courant
            i ==> indice du frameRes
         */
        if (a % 2 != 0)
        {
            if (b == 10)
            {
                scores_text[i].text = "X";
                
            }
            else
            {
                scores_text[i].text = frameRes[i].ToString();
            }

        }
        else if (a % 2 == 0)
        {
            if (b == 10)
            {
                scores_text[i].text = " ";
            }
            if (b+c  == 10 )
            {
                scores_text[i].text = "/";
            }
            else if(b + c < 10)
            {
                scores_text[i].text = frameRes[i].ToString();
            }
        }
        if (d > 0)
        {
            if (d == 10) { scores_text[i].text = "X"; }
            if (d < 10) { scores_text[i].text = frameRes[i].ToString(); }
        }
    }

    void ScoreFind()
    {
        //F1 Résultats :
        if(Ball.frame == 1){
            if ( Ball.nblance == 1){ frameRes[0] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[0], 0, 0,0); }
            if ( Ball.nblance == 2) { frameRes[1] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[0], frameRes[1], 1, 0); }
            GameManager.Instance.Result(Ball.nblance, frameRes[0], frameRes[1], 0);
        }

        //F2 Résultats :
        else if (Ball.frame == 2){
            if (Ball.nblance == 3) { frameRes[2] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[2], 0, 2, 0); }
            if (Ball.nblance == 4) { frameRes[3] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[2], frameRes[3], 3, 0); }
            GameManager.Instance.Result(Ball.nblance, frameRes[2], frameRes[3], 0);
        }

        //F3 Résultats :
        else if (Ball.frame == 3) {
            if ( Ball.nblance == 5) { frameRes[4] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[4], 0, 4, 0); }
            if (Ball.nblance == 6) { frameRes[5] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[4], frameRes[5], 5, 0); }
            GameManager.Instance.Result(Ball.nblance, frameRes[4], frameRes[5], 0);
        }

        //F4 Résultats :
        else if (Ball.frame == 4) {
            if (Ball.nblance == 7) { frameRes[6] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[6], 0, 6, 0); }
            if (Ball.nblance == 8) { frameRes[7] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[6], frameRes[7], 7, 0); }
            GameManager.Instance.Result(Ball.nblance, frameRes[6], frameRes[7], 0);
        }

        //F5 Résultats :
        else if (Ball.frame == 5){
            if ( Ball.nblance == 9) { frameRes[8] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[8], 0, 8, 0); }
            if (Ball.nblance == 10) { frameRes[9] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[8], frameRes[9], 9, 0); }
            GameManager.Instance.Result(Ball.nblance, frameRes[8], frameRes[9], 0);
        }

        //F6 Résultats :
        else if (Ball.frame == 6){
            if ( Ball.nblance == 11) { frameRes[10] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[10], 0, 10, 0); }
            if ( Ball.nblance == 12) { frameRes[11] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[10], frameRes[11], 11, 0); }
            GameManager.Instance.Result(Ball.nblance, frameRes[10], frameRes[11], 0);
        }

        //F7 Résultats :
        else if (Ball.frame == 7){
            if ( Ball.nblance == 13) { frameRes[12] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[12], 0, 12, 0); }
            if ( Ball.nblance == 14) { frameRes[13] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[12], frameRes[13], 13, 0); }
            GameManager.Instance.Result(Ball.nblance, frameRes[12], frameRes[13], 0);
        }

        //F8 Résultats :
        else if (Ball.frame == 8) {
            if (Ball.nblance == 15) { frameRes[14] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[14], 0, 14, 0); }
            if (Ball.nblance == 16) { frameRes[15] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[14], frameRes[15], 15, 0); }
            GameManager.Instance.Result(Ball.nblance, frameRes[14], frameRes[15], 0);
        }

        //F9 Résultats :
        else if (Ball.frame == 9) {
            if (Ball.nblance == 17) { frameRes[16] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[16], 0, 16, 0); }
            if (Ball.nblance == 18) { frameRes[17] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[16], frameRes[17], 17, 0); }
            GameManager.Instance.Result(Ball.nblance,frameRes[16], frameRes[17],0);
        }

        //F10 Résultats :
        else if (Ball.frame == 10) {// A MODIFIER
            if ( Ball.nblance == 19) { frameRes[18] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[18], 0, 18, 0); }
            if (  Ball.nblance == 20) { frameRes[19] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, frameRes[18], frameRes[19], 19, 0); }
            if ( Ball.nblance == 21) { frameRes[20] = GameManager.Instance.count; ScoreDisplay(Ball.nblance, 0, 0, 20, frameRes[20]); }
            GameManager.Instance.Result(Ball.nblance, frameRes[18], frameRes[19], frameRes[20]);
        }

    }


    public int scoreCalculation()
    {
        frames[0] = new Frame(frameRes[0], frameRes[1], 0);
        frames[1] = new Frame(frameRes[2], frameRes[3], 0);
        frames[2] = new Frame(frameRes[4], frameRes[5], 0);
        frames[3] = new Frame(frameRes[6], frameRes[7], 0);
        frames[4] = new Frame(frameRes[8], frameRes[9], 0);
        frames[5] = new Frame(frameRes[10], frameRes[11], 0);
        frames[6] = new Frame(frameRes[12], frameRes[13], 0);
        frames[7] = new Frame(frameRes[14], frameRes[15], 0);
        frames[8] = new Frame(frameRes[16], frameRes[17], 0);
        frames[9] = new Frame(frameRes[18], frameRes[19], frameRes[20]);

        for (int i = 0; i < frames.Length; i++)
        {
            if (i < 9)
            {
                if (frames[i].getFirstscore() == 10)
                { //STRIKE
                  //MANQUE DE CONDITION
                    if (i < 8 && frames[i + 1].getFirstscore() == 10 && frames[i + 2].getFirstscore() == 10)
                    {
                        totalScore += frames[i + 1].getFirstscore() + frames[i + 2].getFirstscore() + 10;
                    }
                    else
                    {
                        totalScore += frames[i + 1].getFirstscore() + frames[i + 1].getSecondscore() + 10;
                    }

                }

                else if (frames[i].getFirstscore() + frames[i].getSecondscore() == 10)
                { //SPARE
                    totalScore += frames[i + 1].getFirstscore() + 10;
                }
                else if (frames[i].getFirstscore() + frames[i].getSecondscore() < 10)//TROU
                {
                    totalScore += frames[i].getFirstscore() + frames[i].getSecondscore();
                }
            }
            else if (i==9)
            {
                totalScore += frames[i].getFirstscore() + frames[i].getSecondscore() + frames[i].getThiredscore();
            }
        }
        Debug.Log("SCORE BOWLING :" + totalScore);
        return totalScore;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreFind();
    }

}

