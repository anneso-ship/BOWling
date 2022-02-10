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

    private float time;
    public float timerInterval = 1;
    float tick;
    public Text Timing;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        frame = 1;
        blocked.SetActive(true);
    }
    
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
        if (collision.gameObject.CompareTag("bloc8"))
        {

            resetBallPosition();
            GameManager.Instance.count = 0;
            blocked.SetActive(true);

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
        if (Input.GetKeyDown(KeyCode.R))
        {
            resetBallPosition();
            GameManager.Instance.count = 0;
            blocked.SetActive(true);
        }


    }
}
