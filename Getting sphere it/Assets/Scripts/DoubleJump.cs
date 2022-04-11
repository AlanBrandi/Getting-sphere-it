using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public float jumpSpeed;
    float jumph = 1;
    public bool isTouchingGround = true;
    Vector3 jump;
    PlayerManager playerManager;
    Jump jumpScript;
    Rigidbody rb;
    UiManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
        jumpScript = GetComponent<Jump>();
        jump = new Vector3(0, jumph, 0);
        rb = GetComponent<Rigidbody>();
        playerManager = FindObjectOfType<PlayerManager>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isTouchingGround)
        {
            rb.AddForce(jump * jumpSpeed, ForceMode.Impulse);
            isTouchingGround = false;
            playerManager.DesligarDoubleJump();
            uiManager.PegouJumpfalse();
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isTouchingGround = true;
        }

    }

}
