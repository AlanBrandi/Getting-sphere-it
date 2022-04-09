using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    UiManager uiManager;
    public int Points;

    private void Start()
    {
        uiManager = GameObject.FindObjectOfType<UiManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiManager.SetScore(Points);
        }
    }
}
