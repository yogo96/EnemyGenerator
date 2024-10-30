using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 1.8f;

    private Vector3 _direction;

    private void Update()
    {
        Move();
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Move()
    {
        transform.LookAt(_direction);
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}