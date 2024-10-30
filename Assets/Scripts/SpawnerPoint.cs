using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    
    public void CreateEnemy()
    {
        Vector3 direction = GetRandomDirection();
        Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.Euler(direction));
        enemy.SetDirection(direction);
    }

    private Vector3 GetRandomDirection()
    {
        int minRotationValue = -180;
        int maxRotationValue = 180;

        int rotationX = Random.Range(minRotationValue, maxRotationValue);
        int rotationZ = Random.Range(minRotationValue, maxRotationValue);
        int rotationY = 0;

        return new Vector3(rotationX, rotationY, rotationZ);
    }
}
