using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDash : MonoBehaviour
{
    public GameObject player;
    Dash dashScript;

    private void Start()
    {
        dashScript = player.GetComponent<Dash>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dashScript.NotTouchingGround = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dashScript.NotTouchingGround = false;
        }
    }
}
