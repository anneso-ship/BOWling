using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
     public balle Ball;
     Vector3[] defaultPos;
     Vector3[] defaultScale;
     Quaternion[] defaultRot;
     Transform[] models;
     public GameManager gameManage;

     void Start()
     {
         //Call to back up the Transform before moving, scaling or rotating the GameObject
         backUpTransform();
     }

     void backUpTransform()
     {
         //Find GameObjects with Model tag
         GameObject[] tempModels = GameObject.FindGameObjectsWithTag("Quille");

         //Create pos, scale and rot, Transform array size based on sixe of Objects found
         defaultPos = new Vector3[tempModels.Length];
         defaultScale = new Vector3[tempModels.Length];
         defaultRot = new Quaternion[tempModels.Length];

         models = new Transform[tempModels.Length];

         //Get original the pos, scale and rot of each Object on the transform
         for (int i = 0; i < tempModels.Length; i++)
         {
             models[i] = tempModels[i].GetComponent<Transform>();

             defaultPos[i] = models[i].position;
             defaultScale[i] = models[i].localScale;
             defaultRot[i] = models[i].rotation;
         }
     }

    //Called when Button is clicked
     public void resetTransform()
     {
         //Restore the all the original pos, scale and rot  of each GameOBject
         for (int i = 0; i < models.Length; i++)
         {
             models[i].position = defaultPos[i];
             models[i].localScale = defaultScale[i];
             models[i].rotation = defaultRot[i];
             models[i].GetComponent<Rigidbody>().isKinematic = true;

         }
     }

    private void blocked()
    {
        for (int i = 0; i < models.Length; i++)
        {
            models[i].GetComponent<Rigidbody>().isKinematic = false;

        }
    }

    private void FixedUpdate()
    {
        if ( (Ball.nblance % 2 != 0 && Ball.reset == true) || ( Ball.nblance >= 19 && Ball.reset == true) )
        {
            resetTransform();
            Ball.reset = false;
            GameManager.Instance.ResetGame();
        }
        if (Input.GetMouseButton(0))
        {
            blocked();
        }

    }

}
