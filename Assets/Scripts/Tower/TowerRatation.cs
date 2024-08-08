using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TowerRatation : MonoBehaviour
{
    [SerializeField] private float _speedRatation;

    Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    private void Update()
    {
        _rigidbody.AddTorque(Vector3.up * Time.deltaTime * _speedRatation);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float torque = touch.position.x * Time.deltaTime * _speedRatation;
                
            }
        }
    }
}
