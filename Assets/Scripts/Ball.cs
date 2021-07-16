using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody _rigidbodyComponent;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.layer);
        if (other.gameObject.layer != 8) return;
        ScoreText.Score++;
        Debug.Log("Money!!!");
    }
}
