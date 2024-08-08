using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : PLatform
{
    [SerializeField] private PlayerBall _ball;
    [SerializeField] private Transform _spawnPoint;

    private void Awake()
    {
        Instantiate(_ball, _spawnPoint.position, Quaternion.identity);
    }
}
