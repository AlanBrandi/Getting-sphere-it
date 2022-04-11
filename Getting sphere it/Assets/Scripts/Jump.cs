using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpSpeed;
    public float jumph = 1;
    public bool isTouchingGround = true;
    Vector3 jump;
    Rigidbody rb;
    PlayerManager player;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        jump = new Vector3(0, jumph, 0);
        rb = GetComponent<Rigidbody>();
        player = FindObjectOfType<PlayerManager>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isTouchingGround)
        {
            audioSource.Play();
            rb.AddForce(jump * jumpSpeed, ForceMode.Impulse);
            isTouchingGround = false;
            player.DesligarDoubleJump();
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
