using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    float hor, ver;
    public float force;

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
        Vector3 direction = new Vector3(hor, 0, ver);
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
