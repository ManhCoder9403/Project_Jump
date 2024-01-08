using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;

    private Transform _thisTransform;
    private Vector2 _startPosition;
    private Vector2 _endPosition;
    private float _speed = 0.01f;
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
}
