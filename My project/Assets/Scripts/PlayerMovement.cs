using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEngine.Rendering.DebugUI;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Animator animator;

    void Start()
    {
       animator = GetComponent<Animator>(); 
    }

    void Update()
    {
        TakeInput();
        Move();
    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        SetAnimation(direction);
    }

    private void TakeInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }

    private void SetAnimation(Vector2 direction) 
    {
        if(direction != Vector2.zero)
            animator.SetBool("IsRunning", true);
        else
            animator.SetBool("IsRunning", false);
    }
    public void ShootAnim(bool value)
    {
        animator.SetBool("IsAttacking", value);
    }
}
