using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Player : MonoBehaviour
{
    public Transform freelook;
    Rigidbody rb;
    float hor, ver;
    public float force;
    Vector3 direction;

    Jump jump;

    float ground_force;
    public float jumpPad_h;
    public float boost_force;
    public float Decrease_force;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = GetComponent<Jump>();
        ground_force = force;
    }
    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Vector3 camFoward = transform.position - freelook.position;
        camFoward = new Vector3(camFoward.x, 0, camFoward.z).normalized;
        Vector3 camRight = Vector3.Cross(Vector3.up, camFoward).normalized;

        direction = camFoward * ver + camRight * hor;
        rb.AddForce(direction * force);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Ground":
                force = ground_force;
            break;

            case "JumpPad":
                jump.jumph = jumpPad_h;
            break;

            case "Boost":
                force = boost_force;
            break;

            case "Decrease":
                force = Decrease_force;
            break;
        }
    }
}
