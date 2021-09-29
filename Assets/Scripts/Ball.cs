using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private bool _hasTouchedGround;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 12) _hasTouchedGround = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_hasTouchedGround) return;
        if (other.gameObject.layer != 8) return;
        ScoreText.Score++;
        Debug.Log(ScoreText.Attempt + "make");
    }
}
