using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLatform : MonoBehaviour
{
    [SerializeField] private float _bounecForce;
    [SerializeField] private float _bounceRadius;

    public void Break()
    {
        PlatformSigment[] platformSigments = GetComponentsInChildren<PlatformSigment>();

        foreach (var paltformq in platformSigments)
        {
            paltformq.Bounce(_bounecForce, transform.position, _bounceRadius);
        }
    }
}
