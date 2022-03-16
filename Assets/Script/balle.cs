using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class balle : MonoBehaviour
{
    public GameObject ball;
    public Vector3 ballPosition;
    public Rigidbody rb;
    public int party;
    Vector3 mouseInScreen;
    float vitesseDeplacement = 100f;
    public bool lance = false;
    public int force;
    public Text frameAff;
    public int frame;
    public int nblance;
    public GameObject blocked;
    public GameObject blocked_1;
    public GameObject blocked_2;
    public bool reset = false;
    public Scorer score;
    public AudioSource RollingBall;
    public Text scoreText;
    public GameOptions gameOption;
    public GameObject scorePanel;
    private void Start()
    {
        //rb = GetComponent<Rigidbody>().isKinematic;
        GetComponent<Rigidbody>().isKinematic = false;
        frame = 1;
        nblance = 1;
        blocked.SetActive(true);
      //  Disabled();
    }

    public void resetBallPosition()
    {
       nblance++;
       ball.transform.position = new Vector3(26.94381f, 24.81796f, -275.39f);
       lance = false;
       if (nblance % 2 != 0) { frame++; }
       if (nblance >= 19 && nblance <= 21) { frame = 10; }
       if (nblance == 22) { 
            scoreText.text = ""+score.scoreCalculation();
            scorePanel.SetActive(true);
            gameOption.EndGame(); 
       }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("underGround"))
        {
            this.enabled = true ;
            resetBallPosition();
            GameManager.Instance.count = 0;
            blocked.SetActive(true);
            //RollingBall.Pause();
            reset = true;
        }
    }

    /*void Disabled()
    {
        if (Input.GetMouseButton(1))
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }*/
    private void Update()
    {
        frameAff.text = "FRAME " + frame + ", " + " lancé :" + nblance;
        if(nblance == 22) { frameAff.text = ""; GameManager.Instance.PartyRes.text = ""; }
        /*if (nblance % 2 == 0) { nblance=1; } 
        else if (party % 2 != 0) { nblance = 2; }*/

        //DERNIER FRAME
        
       
        if (lance == false)
        { //Choix trajectoire
            ballPosition = gameObject.transform.position;
            float vDeplacement = Input.GetAxis("Horizontal") * vitesseDeplacement;
            rb.AddForce(vDeplacement, 0, 0);
            blocked.SetActive(true);
            blocked_1.SetActive(true);
            blocked_2.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {   //Lancer la balle
            
                lance = true;
                rb.AddForce(ballPosition.x, 0, 5500);
                blocked.SetActive(false);
                blocked_1.SetActive(false);
                blocked_2.SetActive(false);
                //RollingBall.Play();
            
        }

        



    }
}
