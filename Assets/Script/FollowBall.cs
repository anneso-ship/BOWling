using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public GameObject ball;
    public Vector3 decalage;
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music.Play();
        
        decalage = new Vector3(-0.8f, 25.0f, -125f);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = ball.transform.position + decalage;
    }
}
