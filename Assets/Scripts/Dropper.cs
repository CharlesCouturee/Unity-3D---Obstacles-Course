using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;

    Rigidbody rb;
    MeshRenderer mr;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();

        mr.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            mr.enabled = true;
            rb.useGravity = true;
        }
    }
}
