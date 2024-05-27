using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 1f;
    [SerializeField] float zValue = 0f;

    Vector3 moveInput;
    Vector2 rotationInput;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        transform.Translate(xInput * xValue * Time.deltaTime, 0f, zInput * zValue * Time.deltaTime);
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void OnLook(InputValue value)
    {
        rotationInput = value.Get<Vector2>();
    }
}
