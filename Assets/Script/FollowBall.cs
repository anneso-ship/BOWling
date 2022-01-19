using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public GameObject ball;
    public Vector3 decalage;
    // Start is called before the first frame update
    void Start()
    {
        decalage = new Vector3(-0.8f, 15.0f, -75f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + decalage;
    }
}
