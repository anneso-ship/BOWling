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

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        frame = 1;
       
    }
    
    public void resetBallPosition()
    {
        
            party++;
        Debug.Log("FRAME :" + party);
            ball.transform.position = new Vector3(-61.18f, 35f, -471.6f);
            lance = false;
            if (party % 2 == 0) { frame++; }
        
    }

    private void Update()
    {
        
        frameAff.text = "FRAME " + frame + ", " + "lancé :" + nblance;
        
        if (party % 2 == 0) { nblance=1; } 
        else if (party % 2 != 0) { nblance = 2; }

        if (lance == false)
        {
            ballPosition = gameObject.transform.position;
            float vDeplacement = Input.GetAxis("Horizontal") * vitesseDeplacement;
            rb.AddForce(vDeplacement, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lance = true;
            //rb.AddForce(transform.forward*force);
            rb.AddForce(ballPosition.x, 0, 80000);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            resetBallPosition();
        }


    }
}
