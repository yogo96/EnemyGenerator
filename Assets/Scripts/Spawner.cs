using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnerPoint> _spawnerPoints;

    private WaitForSeconds _waitTime;
    private Coroutine _coroutine;
    
    private void Awake()
    {
        _waitTime = new WaitForSeconds(2);
    }

    private void OnEnable()
    {
        if (_coroutine == null)
            _coroutine = StartCoroutine(EnemyCreating());
    }

    private void OnDisable()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);
    }

    private IEnumerator EnemyCreating()
    {
        while (enabled == true)
        {
            int spawnerIndex = Random.Range(0, _spawnerPoints.Count);
            _spawnerPoints[spawnerIndex].CreateEnemy();
            yield return _waitTime;
        } 
    }
}
