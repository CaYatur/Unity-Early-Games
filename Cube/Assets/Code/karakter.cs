using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 1.0f;
    [SerializeField] private float jumpForce = 1.0f;

    private Rigidbody2D rdBody;
    
    void Start()
    {
        rdBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed; 
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rdBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
