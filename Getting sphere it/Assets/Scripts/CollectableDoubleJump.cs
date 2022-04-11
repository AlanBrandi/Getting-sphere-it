using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableDoubleJump : MonoBehaviour
{
    PlayerManager playerManager;
    UiManager uiManager;
    private void Start()
    {
        playerManager = FindObjectOfType<PlayerManager>();
        uiManager = FindObjectOfType<UiManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerManager.LigarDoubleJump();
            uiManager.PegouJumpTrue();
            Destroy(this.gameObject);
        }
    }
}
