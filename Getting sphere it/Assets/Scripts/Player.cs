using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    float hor, ver;
    public float force;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(hor, 0, ver);
        rb.AddForce(direction * force);
    }
}
