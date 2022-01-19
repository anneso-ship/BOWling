using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class quilles : MonoBehaviour
{
    Vector3[] defaultPos;
    Quaternion[] defaultRot;
    Transform[] models;

    public int nbQuille;
    
    public GameManager gameManage;
    public balle Ball;


    public bool enableCheck;
    public Material mat;
    public bool isDown;



    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        GameManager.Instance.Quilles.Add(this);
        
    }

  

   

    private void OnCollisionEnter(Collision collision)
    {
        //Ajouter le tag "Ball" � la boule et "Quille" aux quilles
        enableCheck = collision.gameObject.CompareTag("Ball") || collision.gameObject.CompareTag("Quille") || collision.gameObject.CompareTag("bloc8")  ;
    }

    

    void FixedUpdate()
    {
        
        if (!enableCheck)
            return;

        /*Si le mod�le de la quille est correctement fait son Up (fl�che verte) pointe vers le haut.
       * Vector3.Dot retourne une valeur entre [-1,1] en fonction de 2 vecteurs (dot product).
       * si le Up de la quille est dans la m�me direction que le Up du monde, le produit sera de 1
       * donc si au bout de X seconde, on a un r�sulta inf�rieur � 1, la quille n'est plus � la verticale
       */
        if (Vector3.Dot(transform.up, Vector3.up) < 0.95)
        {
            GameManager.Instance.count++;
            mat.SetColor("_Color", Color.green);
            isDown = true;
            this.enabled = false;
        }
        


    }

    
}
