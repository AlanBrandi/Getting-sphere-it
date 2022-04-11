using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public GameObject player;
    PlayerManager playerManager;
    Player playerScript;
    public float dashSpeed;
    public bool NotTouchingGround = true;
    float gravityDashSpeed = 0;
    Rigidbody rb;
    UiManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
        rb = GetComponent<Rigidbody>();
        playerScript = player.GetComponent<Player>();
        playerManager = FindObjectOfType<PlayerManager>();
    }

    private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Mouse0) && NotTouchingGround)
        {
            StartCoroutine(Das());
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            NotTouchingGround = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        NotTouchingGround = false;
    }
    IEnumerator Das()
    {
        float forceorg = playerScript.force;
        playerScript.force *= dashSpeed;
        rb.useGravity = false;
        rb.velocity = new Vector2(rb.velocity.x, y: -gravityDashSpeed);
        playerManager.DesligarDash();
        uiManager.PegouDashfalse();


        yield return new WaitForSeconds(.2f);

        rb.useGravity = true;
        playerScript.force = forceorg;
        NotTouchingGround = false;
    }
}
