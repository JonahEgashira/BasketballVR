using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    [SerializeField] private GameObject prefabBall;
    [SerializeField] private GameObject ballStand;
    
    private GameObject ball;
    private List<GameObject> balls;

    private Vector3 adjustValue;
    // Start is called before the first frame update
    void Start()
    {
        balls = new List<GameObject>();
        adjustValue = new Vector3(0.0f, 1.0f, 0.0f);
        ball = Instantiate(prefabBall, ballStand.transform.position + adjustValue, Quaternion.identity);
        balls.Add(ball);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void GenerateBall()
    {
        GameObject newBall = Instantiate(prefabBall, ballStand.transform.position + adjustValue, Quaternion.identity);
        balls.Add(newBall);
        if (balls.Count >= 3)
        {
            Destroy(balls[0]);
            balls.RemoveAt(0);
        }
    }
    
}
