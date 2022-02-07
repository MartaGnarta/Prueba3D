using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private InputSystemKeyboard _input;
    private Animator _anim;
    private Rigidbody _rb;
    private CharacterController _controller;

    public float speed;
    public float rotationSpeed;

    void Awake()
    {
        _input = GetComponent<InputSystemKeyboard>();
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.hor != 0)
        {
            _controller.Move(transform.forward * _input.ver * speed * Time.deltaTime);
            transform.Rotate(0, rotationSpeed * _input.hor, 0);
        }
    }
}