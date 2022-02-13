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
    float vitesseDeplacement = 1000f;
    public bool lance = false;
    public int force;
    public Text frameAff;
    public int frame;
    public int nblance;
    public GameObject blocked;

    public bool reset = false;
    
    public Text Timing;

    public int lancé;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        frame = 1;lancé = 1;

        blocked.SetActive(true);
        
    }

   /* IEnumerator timer()
    {
        while (time > 0)
        {
            time--;
            yield return new WaitForSeconds(1f);
            Timing.text = "" + time;
        }
    }
    */

    public void resetBallPosition()
    {
       party++;
       Debug.Log("FRAME :" + party);
       ball.transform.position = new Vector3(34.0438f, 24.81796f, -275.39f);
       lance = false;
       if (party % 2 == 0) { frame++; }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("underGround"))
        {
            resetBallPosition();
            GameManager.Instance.count = 0;
            blocked.SetActive(true);
            reset = true;
        }
    }


    private void Update()
    {
        
        frameAff.text = "FRAME " + frame + ", " + " lancé :" + nblance;
        
        if (party % 2 == 0) { nblance=1; } 
        else if (party % 2 != 0) { nblance = 2; }


        if (lance == false)
        { //Choix trajectoire
            ballPosition = gameObject.transform.position;
            float vDeplacement = Input.GetAxis("Horizontal") * vitesseDeplacement;
            rb.AddForce(vDeplacement, 0, 0);
            blocked.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {   //Lancer la balle
            lance = true;
            rb.AddForce(ballPosition.x, 0, 80000);
            blocked.SetActive(false);
        }
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            resetBallPosition();
            GameManager.Instance.count = 0;
            blocked.SetActive(true);
        }
        if (time == 0)
        {
            time = -1;
            Timing.text = "";
            resetBallPosition();
            GameManager.Instance.count = 0;
            blocked.SetActive(true);
        }
        */
    }
}
