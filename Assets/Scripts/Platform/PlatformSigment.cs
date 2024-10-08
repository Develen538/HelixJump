using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlatformSigment : MonoBehaviour
{


   private Rigidbody _rigidbody;

    public void Bounce(float force, Vector3 center, float radius)
    {
        if (TryGetComponent(out Rigidbody rigidbody))
        {
            rigidbody.isKinematic = false;
            rigidbody.AddExplosionForce(force,center,radius);
        }
    }
}
