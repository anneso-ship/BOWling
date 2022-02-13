using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class quilles : MonoBehaviour
{
    public Material _mat;
    private Vector3 _startPosition;
    private bool enableCheck;
    //public Rigidbody _rb;

    private void Start()
    {
        //R�cup�ration des r�f�rences
        _mat = GetComponent<Renderer>().material;
        _startPosition = transform.position;
       // _rb = GetComponent<Rigidbody>();

        //Singleton, c'est un peu complexe mais en gros tu ne dois avoir qu'un seul GameManager dans ton jeu. De mauvaises choses vont se passer sinon.
        GameManager.Instance.Quilles.Add(this);
    }

    public void ResetStatus()
    {
       // _rb.velocity = Vector3.zero;
        //_rb.angularVelocity = Vector3.zero;
        transform.SetPositionAndRotation(_startPosition, Quaternion.identity); //Ne pas utiliser transform.position et transform.rotation, cette ligne est plus optimis�e
        _mat.SetColor("_Color", Color.white);
        enableCheck = false;
        this.enabled = true;
        gameObject.SetActive(true);
    }

    public void Update()
    {
        if (!enableCheck) //on veut �viter de calculer le Vector3.dot � chaque frame pour chaque quille, on ne va v�rifier que les quilles qui ont �t� touch�e par la boule ou une autre quille.
            return;

        /*Si le mod�le de la quille est correctement fait son Up (fl�che verte) pointe vers le haut.
       * Vector3.Dot retourne une valeur entre [-1,1] en fonction de 2 vecteurs (dot product).
       * si le Up de la quille est dans la m�me direction que le Up du monde, le produit sera de 1
       * donc si au bout de X seconde, on a un r�sulta inf�rieur � 1, la quille n'est plus � la verticale
       */
        if (Vector3.Dot(transform.up, Vector3.up) < 0.95)
        {
            GameManager.Instance.count++; //on ajoute 1 au compteur de quilles couch�es
            _mat.SetColor("_Color", Color.green);

            this.enabled = false; //La quille est maintenant couch�e, on arr�te compl�tement le script, il n'est plus utile.
        }
    }




    private void OnCollisionEnter(Collision collision)
    {
        //Ajouter le tag "Ball" � la boule et "Quille" aux quilles
        enableCheck = collision.gameObject.CompareTag("Ball") || collision.gameObject.CompareTag("Quille")  ;
    }



}
