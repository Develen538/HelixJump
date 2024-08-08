using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBulder : MonoBehaviour
{
    [SerializeField] private int _levelCount;
    [SerializeField] private GameObject _beam;
    [SerializeField] private float _additionalScale;
    [SerializeField] private StartPlatform _spawnPlatform;
    [SerializeField] private PLatform[] _platform;
    [SerializeField] private FinishPlatform _finishPlatform;

    private float _startAndFinish = 0.5f;

    public float BeamScaleY => _levelCount / 2f + _startAndFinish + _additionalScale /2f;

    private void Start()
    {
        Buld();
    }

    private void Buld()
    {
        GameObject beam = Instantiate(_beam, transform);
        beam.transform.localScale = new Vector3(1,BeamScaleY, 1);

        Vector3 spawnPosition = beam.transform.position;
        spawnPosition.y += beam.transform.localScale.y - _additionalScale;
        SpawnPlatform(_spawnPlatform, ref spawnPosition, beam.transform);

        for (int i = 0; i < _levelCount; i++)
        {
            SpawnPlatform(_platform[Random.Range(0, _platform.Length)], ref spawnPosition, beam.transform);
        }

        SpawnPlatform(_finishPlatform, ref spawnPosition, beam.transform);
    }

    private void SpawnPlatform(PLatform pLatform, ref Vector3 SpawnPosition, Transform parant)
    {
        Instantiate(pLatform, SpawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), parant);
        SpawnPosition.y -= 1;
    }
}
