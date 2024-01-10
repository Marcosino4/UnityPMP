using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public KeyCode rightKey, leftKey;
    public float speed;

    private Rigidbody2D _rb;
    private Vector2 _dir;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _dir = Vector2.zero; 
        _animator.SetBool("isWalking", false);

        if (Input.GetKey(rightKey))
        {
            _animator.SetBool("isWalking", true);
            _dir = new Vector2(1, 0);
            _spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(leftKey))
        {
            _animator.SetBool("isWalking", true);
            _dir = new Vector2(-1, 0);
            _spriteRenderer.flipX = false;
        }

    }

    private void FixedUpdate()
    {
        _rb.velocity = _dir * speed;
    }
}
