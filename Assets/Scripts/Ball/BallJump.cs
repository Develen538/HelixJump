using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallJump : MonoBehaviour
{
    [SerializeField] private float _jump;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out PlatformSigment platformSigment))
        {
            _rigidbody.AddForce(Vector3.up * _jump, ForceMode.Impulse);
        }
    }
}
