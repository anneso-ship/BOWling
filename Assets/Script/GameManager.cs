using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int numberFrame = 0;
    public int numberCase = 0;
    public Text PartyRes;
    public balle Ball;
    ResetObject resposQuille ;
    public static GameManager Instance;
    public List<quilles> Quilles = new List<quilles>();//Liste de quilles
    public Text quilleDown;
    public int _count;

    public AudioSource Strike;

    private void Awake() { Instance = this; }

    public int count
    {
        get
        {
            return _count;
        }
        set
        {
            _count = value;
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        quilleDown.text = "" + count;
    }

    public void Result( int numberParty,int a, int b, int c)
    {
        //STRIKE
        if(numberParty % 2!=0 && a == 10) { PartyRes.text = "STRIKE !!"; Strike.Play();  }

        else if (numberParty%2 == 0) {
            //SPARE
            if (a+b == 10) { PartyRes.text = "SPARE !!"; }

            //TROU
            if (a+b+c < 10) { PartyRes.text = "TROU !!"; }
        }
    }

      public void ResetGame() 
    {
        for (int q = 0; q < Quilles.Count; ++q)
        {
            Quilles[q].ResetStatus();
        }
        count = 0;
        UpdateUI();
    }

}
