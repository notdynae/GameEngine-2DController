using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform _target;
    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    private float damping;
    
    private Vector3 _velocity = Vector3.zero;
    
    void FixedUpdate()
    {
        Vector3 desiredPosition = GameManager.Instance.player.transform.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref _velocity, damping);
    }
}
