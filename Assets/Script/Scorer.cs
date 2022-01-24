using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public int[] frameRes = new int[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public balle Ball;

    //Affichage frame 1
    public Text f1lance_1;  public Text f1lance_2;

    //Affichage frame 2
    public Text f2lance_1; public Text f2lance_2;

    //Affichage frame 3
    public Text f3lance_1; public Text f3lance_2;

    //Affichage frame 4
    public Text f4lance_1; public Text f4lance_2;

    //Affichage frame 5
    public Text f5lance_1; public Text f5lance_2;

    //Affichage frame 6
    public Text f6lance_1; public Text f6lance_2;

    //Affichage frame 7
    public Text f7lance_1; public Text f7lance_2;

    //Affichage frame 8
    public Text f8lance_1; public Text f8lance_2;

    //Affichage frame 9
    public Text f9lance_1; public Text f9lance_2;

    //Affichage frame 10
    public Text f10lance_1; public Text f10lance_2; public Text f10lance_3;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void AfficheScoring()
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
    }

    // Update is called once per frame
    void Update()
    {
        AfficheScoring();

        //Affichage frame 1
        f1lance_1.text = "" + frameRes[0];
        f1lance_2.text = "" + frameRes[1];

        //Affichage frame 2
        f2lance_1.text = "" + frameRes[2];
        f2lance_2.text = "" + frameRes[3];

        //Affichage frame 3
        f3lance_1.text = "" + frameRes[4];
        f3lance_2.text = "" + frameRes[5];

        //Affichage frame 4
        f4lance_1.text = "" + frameRes[6];
        f4lance_2.text = "" + frameRes[7];

        //Affichage frame 5
        f5lance_1.text = "" + frameRes[8];
        f5lance_2.text = "" + frameRes[9];

        //Affichage frame 6
        f6lance_1.text = "" + frameRes[10];
        f6lance_2.text = "" + frameRes[11];

        //Affichage frame 7
        f7lance_1.text = "" + frameRes[12];
        f7lance_2.text = "" + frameRes[13];

        //Affichage frame 8
        f8lance_1.text = "" + frameRes[14];
        f8lance_2.text = "" + frameRes[15];

        //Affichage frame 9
        f9lance_1.text = "" + frameRes[16];
        f9lance_2.text = "" + frameRes[17];

        //Affichage frame 10
        f10lance_1.text = "" + frameRes[18];
        f10lance_2.text = "" + frameRes[19];
    }
}
