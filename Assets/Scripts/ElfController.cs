using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfController : MonoBehaviour
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

    void OnEnable()
    {
        _input.OnFire += Punch;
    }

    void OnDisable()
    {
        _input.OnFire -= Punch;
    }


    // Update is called once per frame
    void Update()
    {
        if (_input.ver != 0)
        {
            _anim.SetBool("run", true);
            _controller.Move(transform.forward * _input.ver * speed * Time.deltaTime);
        }
        else
        {
            _anim.SetBool("run", false);
        }

        if (_input.hor != 0)
        {
            transform.Rotate(0, rotationSpeed * _input.hor, 0);
        }
    }

    private void Punch()
    {
        _anim.SetTrigger("punch");
    }
}
