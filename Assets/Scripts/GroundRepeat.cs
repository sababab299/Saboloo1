using Unity.Hierarchy;
using UnityEngine;

public class GroundRepeat : MonoBehaviour
{

    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _length = 7f;
    private SpriteRenderer _spriteRenderer;
    private Vector2 startSize;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        _spriteRenderer.size=new Vector2(_spriteRenderer.size.x+_speed*Time.deltaTime, _spriteRenderer.size.y);
        //if(_spriteRenderer.size.x > _length)
        //{
        //    _spriteRenderer.size = startSize;
        //}
    }
}
