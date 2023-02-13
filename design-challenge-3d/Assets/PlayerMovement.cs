using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private CharacterController _controller;
    public float gravity = 9.87f;
    public float verticalSpeed = 0.0f;
    public float mouseSensitivity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        _controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        MyRotate();
    }

    void Movement()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        //Gravy
        if (_controller.isGrounded)
            verticalSpeed = 0.0f;
        else
            verticalSpeed -= gravity * Time.deltaTime;

        Vector3 gravityMove = new Vector3(0, verticalSpeed, 0);
        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove;
        _controller.Move(move * speed * Time.deltaTime + gravityMove * speed * Time.deltaTime);
    }

    void MyRotate()
    {
        float horizontalRotation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");   

        transform.Rotate(0, horizontalRotation*mouseSensitivity, 0);
        Camera.main.transform.Rotate(-verticalRotation * mouseSensitivity, 0, 0);
    }
}
