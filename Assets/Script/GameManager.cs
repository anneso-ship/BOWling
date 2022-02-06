using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int numberFrame = 0;
    public int numberCase = 0;
    public int ResultParty = 0;
    public Text PartyRes;
    public balle Ball;
    ResetObject resposQuille ;
    public int[,] CaseParty = new int[3, 21] {
       /*STRIKE*/ { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1}, 
       /*SPARE*/  { 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 2},
       /*TROU*/   { 0, 3, 0, 3, 0, 3, 0, 3, 0, 3, 0, 3, 0, 3, 0, 3, 0, 3, 0, 3, 3}
    };
    public static GameManager Instance;
    public List<quilles> Quilles = new List<quilles>();//Liste de quilles
    public Text quilleDown;
    public int _count;

    public GameManager()
    {
        this.numberFrame = numberFrame;
        this.numberCase = numberCase;
        this.ResultParty = ResultParty;
    }

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

    public int Result( int numberParty, int count)
    {
        //STRIKE
        if(numberParty % 2==0 && count == 10) { ResultParty = CaseParty[0,numberParty]; PartyRes.text = "STRIKE !!"; }

        else if (numberParty != 0) {
            //SPARE
            if (count == 10) { ResultParty = CaseParty[1, numberParty]; PartyRes.text = "SPARE !!"; }

            //TROU
            if (count < 10) { ResultParty = CaseParty[2, numberParty]; PartyRes.text = "TROU !!"; }
        }
        return ResultParty;
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

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Result(Ball.party, count);
    }
}
