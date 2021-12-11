using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour
{
    public Transform anchor;
    public AudioClip sound;
    private float _maxDistance = 100;
    private LineRenderer _lineRenderer;

    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 adjustVector = new Vector3(-0.05f, 0.0f, 0.0f);
        Ray ray = new Ray(anchor.position + adjustVector, anchor.forward);

        _lineRenderer.SetPosition(0, ray.origin);
        if (Physics.Raycast(ray, out hit, _maxDistance))
        {
            _lineRenderer.SetPosition(1, hit.point);
            GameObject target = hit.collider.gameObject;

            if (OVRInput.GetDown(OVRInput.RawButton.A))
            {
                if (target.CompareTag("RayObject"))
                {
                    AudioSource.PlayClipAtPoint(sound, transform.position);
                    target.GetComponent<MeshRenderer>().material.color = Color.red;
                }
            }
        }
        else
        {
            _lineRenderer.SetPosition(1, ray.origin + (ray.direction * _maxDistance));
        }
    }
}
