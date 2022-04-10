using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public GameObject player;
    Player playerScript;
    public float dashSpeed;
    public bool NotTouchingGround = true;
    float gravityDashSpeed = 0;
    Rigidbody rb;




    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerScript = player.GetComponent<Player>();

    }

    private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.P) && NotTouchingGround)
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


        yield return new WaitForSeconds(.2f);

        rb.useGravity = true;
        playerScript.force = forceorg;
        NotTouchingGround = false;
        
    }
}
