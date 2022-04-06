using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetJump : MonoBehaviour
{
    public GameObject Player;
    Jump PlayerScript;

    private void Start()
    {
        
        PlayerScript = Player.GetComponent<Jump>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScript.enabled = true;
            Destroy(gameObject);
        }
    }
}
