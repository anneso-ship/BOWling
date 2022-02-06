using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{

    public int[] frameRes = new int[21] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public balle Ball;

   
    public Text[] scores_text;
    public Text[] scores_frame;
    public int[] frame = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void ScoreDisplay()
    {
        //F1 Résultats :
        if (Ball.party == 0 && Ball.frame == 1 && Ball.nblance == 1) { frameRes[0] = GameManager.Instance.count; }
        if (Ball.party == 1 && Ball.frame == 1 && Ball.nblance == 2) { frameRes[1] = GameManager.Instance.count; }
   
        //F2 Résultats :
        if (Ball.party == 2 && Ball.frame == 2 && Ball.nblance == 1) { frameRes[2] = GameManager.Instance.count; }
        if (Ball.party == 3 && Ball.frame == 2 && Ball.nblance == 2) { frameRes[3] = GameManager.Instance.count; }
       
        //F3 Résultats :
        if (Ball.party == 4 && Ball.frame == 3 && Ball.nblance == 1) { frameRes[4] = GameManager.Instance.count; }
        if (Ball.party == 5 && Ball.frame == 3 && Ball.nblance == 2) { frameRes[5] = GameManager.Instance.count; }
      
        //F4 Résultats :
        if (Ball.party == 6 && Ball.frame == 4 && Ball.nblance == 1) { frameRes[6] = GameManager.Instance.count; }
        if (Ball.party == 7 && Ball.frame == 4 && Ball.nblance == 2) { frameRes[7] = GameManager.Instance.count; }
       
        //F5 Résultats :
        if (Ball.party == 8 && Ball.frame == 5 && Ball.nblance == 1) { frameRes[8] = GameManager.Instance.count; }
        if (Ball.party == 9 && Ball.frame == 5 && Ball.nblance == 2) { frameRes[9] = GameManager.Instance.count; }
       
        //F6 Résultats :
        if (Ball.party == 10 && Ball.frame == 6 && Ball.nblance == 1) { frameRes[10] = GameManager.Instance.count; }
        if (Ball.party == 11 && Ball.frame == 6 && Ball.nblance == 2) { frameRes[11] = GameManager.Instance.count; }
      
        //F7 Résultats :
        if (Ball.party == 12 && Ball.frame == 7 && Ball.nblance == 1) { frameRes[12] = GameManager.Instance.count; }
        if (Ball.party == 13 && Ball.frame == 7 && Ball.nblance == 2) { frameRes[13] = GameManager.Instance.count; }
      
        //F8 Résultats :
        if (Ball.party == 14 && Ball.frame == 8 && Ball.nblance == 1) { frameRes[14] = GameManager.Instance.count; }
        if (Ball.party == 15 && Ball.frame == 8 && Ball.nblance == 2) { frameRes[15] = GameManager.Instance.count; }
        
        //F9 Résultats :
        if (Ball.party == 16 && Ball.frame == 9 && Ball.nblance == 1) { frameRes[16] = GameManager.Instance.count; }
        if (Ball.party == 17 && Ball.frame == 9 && Ball.nblance == 2) { frameRes[17] = GameManager.Instance.count; }
      
        //F10 Résultats :
        if (Ball.party == 18 &&  Ball.frame == 10 && Ball.nblance == 1) { frameRes[18] = GameManager.Instance.count; }
        if (Ball.party == 19 && Ball.frame == 10 && Ball.nblance == 2) { frameRes[19] = GameManager.Instance.count; }
        if (Ball.party == 20 && Ball.frame == 10 && Ball.nblance == 3) { frameRes[20] = GameManager.Instance.count; }
     

        for (int i = 0; i < frameRes.Length; i++)
        {
            if (frameRes[i] == -1)
            {
                scores_text[i].text = " ";
            }
            else if (frameRes[i] == 10)
            {
                scores_text[i].text = "X";
                frameRes[i + 1] = 0;
            }
            else if (frameRes[i] == 0)
            {
                scores_text[i].text = "-";
            }
            else if (i > 0)
            {
                if ((frameRes[i] + frameRes[i - 1] == 10) && (frameRes[i - 1] == 10))
                {

                    scores_text[i].text = " ";
                }
                else if (frameRes[i] + frameRes[i - 1] == 10)
                {

                    scores_text[i].text = "/";
                }
                else
                {
                    scores_text[i].text = frameRes[i].ToString();
                }
            }
            else
            {
                scores_text[i].text = frameRes[i].ToString();
            }
        }



    }

    void FrameDisplay()
    {
        frame[0] = frameRes[0] + frameRes[1];
        frame[1] = frameRes[2] + frameRes[3];
        frame[2] = frameRes[4] + frameRes[5];
        frame[3] = frameRes[6] + frameRes[7];
        frame[4] = frameRes[8] + frameRes[9];
        frame[5] = frameRes[10] + frameRes[11];
        frame[6] = frameRes[12] + frameRes[13];
        frame[7] = frameRes[14] + frameRes[15];
        frame[8] = frameRes[16] + frameRes[17];
        frame[9] = frameRes[18] + frameRes[19];
        
        for(int i=0; i < frame.Length; i++)
        {
            scores_frame[i].text = "" + frame[i]; 
        }

    }

    // Update is called once per frame
    void Update()  { 
        ScoreDisplay();
        FrameDisplay();
    }
}
