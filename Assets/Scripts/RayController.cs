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

    private void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(anchor.position, anchor.forward);
        
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
            else
            {
                _lineRenderer.SetPosition(1, ray.origin + (ray.direction * _maxDistance));
            }
        }
    }
}
