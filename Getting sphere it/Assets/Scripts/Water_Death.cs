using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Death : MonoBehaviour
{
   UiManager uimanager;
    private void Start()
    {
        uimanager = GameObject.FindObjectOfType<UiManager>();
        Debug.Log(uimanager);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        if (other.CompareTag("Player"))
        {
            Debug.Log("TriggerPlayer");
            uimanager.SetLife(10);
        }
    }
}
