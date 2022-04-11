using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableDash : MonoBehaviour
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
            playerManager.LigarDash();
            uiManager.PegouDashTrue();
            Destroy(this.gameObject);
        }
    }
}
