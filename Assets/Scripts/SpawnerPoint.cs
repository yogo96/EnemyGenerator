using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private TargetPoint _targetPoint;
    
    public void CreateEnemy()
    {
        Vector3 direction = _targetPoint.transform.position;
        Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.Euler(direction));
        enemy.SetDirection(direction);
    }

}
