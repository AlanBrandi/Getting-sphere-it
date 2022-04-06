using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpSpeed;
    float jumph = 1;
    public bool isTouchingGround = true;
    Vector3 jump;
    Rigidbody rb;

    private void Start()
    {
        jump = new Vector3(0, jumph, 0);
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isTouchingGround)
        {
            rb.AddForce(jump * jumpSpeed, ForceMode.Impulse);
            isTouchingGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isTouchingGround = true;
        }
    }
}
