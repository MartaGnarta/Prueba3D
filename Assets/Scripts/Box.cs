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
    public bool holding;

    public Light light;

    void Awake()
    {
        _input = GetComponent<InputSystemKeyboard>();
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
        _controller = GetComponent<CharacterController>();
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.ver != 0)
        {
            _controller.Move(transform.forward * _input.ver * speed * Time.deltaTime);            
        }

        if (_input.hor != 0)
        {
            transform.Rotate(0, rotationSpeed * _input.hor, 0);
        }

        if (holding)
        {
            var targetRotation = Quaternion.LookRotation(Vector3.forward, Vector3.one);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 0);
        }        
    }

    public void ActionLavel()
    {
        light.intensity = 100f;
    }

    public void ActionButton()
    {
        light.intensity = 0f;
    }

    public void ActionInterruptor()
    {
        light.intensity = 100f;
    }
}