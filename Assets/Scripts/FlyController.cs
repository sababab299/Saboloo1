using UnityEngine;

public class FlyManager : MonoBehaviour
{
    [SerializeField] private float _velocity = 5f;
    [SerializeField] private float _rotationSpeed = 5f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.linearVelocity = Vector2.up*_velocity;
        }
    }
    private void FixedUpdate()
    {
        transform.rotation= Quaternion.Euler(0,0,rb.linearVelocity.y*_rotationSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
    }
}
