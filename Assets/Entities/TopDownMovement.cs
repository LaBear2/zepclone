using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _Rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _Rigidbody = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        _controller.onMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        _Rigidbody.velocity = direction;
    }
}
