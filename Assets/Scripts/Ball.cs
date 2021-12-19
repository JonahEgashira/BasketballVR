using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private bool _hasTouchedGround;

    private GameObject _ballGenerator;

    // Start is called before the first frame update
    void Start()
    {
        _ballGenerator = GameObject.Find("BallGenerator");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor") && !_hasTouchedGround)
        {
            _hasTouchedGround = true;
            _ballGenerator.GetComponent<BallGenerator>().GenerateBall();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_hasTouchedGround) return;
        if (other.gameObject.layer != 8) return;
        ScoreText.Score++;
        TargetController.score++;
        Debug.Log(ScoreText.Attempt + "make");
    }
}
