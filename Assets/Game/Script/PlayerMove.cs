using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;

    private Transform _thisTransform;
    private Vector2 _startPosition;
    private Vector2 _endPosition;
    private float _speed = 0.02f;
    void Start()
    {
        _thisTransform = this.transform;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rb.isKinematic = true;
            _startPosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            _endPosition = Input.mousePosition;
            Vector2 _pullDirection = _endPosition - _startPosition;
            _rb.isKinematic = false;
            _rb.AddForce(-_pullDirection * _speed, ForceMode2D.Impulse);
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(1 << collision.gameObject.layer);
        Debug.Log(LayerMask.GetMask("Wall"));
        if (1 << collision.gameObject.layer == LayerMask.GetMask("Wall"))
        {
            _rb.velocity = new Vector2(-_rb.velocity.x, _rb.velocity.y);
        }
    }*/
}
