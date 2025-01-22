using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform _target;
    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    private float damping;
    
    private Vector3 _velocity = Vector3.zero;

    private void Target(GameObject target)
    {
        _target = target.transform;
    }
    
    public void Start()
    {
        Target(GameObject.Find("Player"));
    }

    void FixedUpdate()
    {
        Vector3 desiredPosition = _target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref _velocity, damping);
    }
}
