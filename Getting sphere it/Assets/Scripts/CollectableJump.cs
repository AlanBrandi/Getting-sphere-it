using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableJump : MonoBehaviour
{
    PlayerManager playerManager;
    private void Start()
    {
        playerManager = FindObjectOfType<PlayerManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerManager.LigarJump();
            Destroy(this.gameObject);
        }
    }
}
