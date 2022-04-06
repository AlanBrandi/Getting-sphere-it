using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDoubleJump : MonoBehaviour
{
    public GameObject Player;
    DoubleJump PlayerScript;
    Jump PlayerScript2;

    private void Start()
    {
        PlayerScript = Player.GetComponent<DoubleJump>();
        PlayerScript2 = Player.GetComponent<Jump>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScript.enabled = true;
            PlayerScript2.enabled = false;
            Destroy(gameObject);
        }
    }
}
