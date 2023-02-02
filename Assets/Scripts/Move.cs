using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float _speed = 2;
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    private float _jumpForse = 5;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0,0);
            _animator.SetBool("isMoveRight", true);
        }
        else
        {
            _animator.SetBool("isMoveLeft", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _animator.SetBool("isMoveLeft", true);
        }
        else
        {
            _animator.SetBool("isMoveLeft", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            // _rigidbody2D.AddForce(Vector2.up*_jumpForse);
            transform.Translate(0, _speed * Time.deltaTime*_jumpForse, 0);
        }
    }
}
