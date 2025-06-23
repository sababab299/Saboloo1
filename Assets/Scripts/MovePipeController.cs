using UnityEngine;

public class MovePipeController : MonoBehaviour
{
    [SerializeField] private float _speed = 0.7f;

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
