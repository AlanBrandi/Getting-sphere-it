using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winscript : MonoBehaviour
{
    public UiManager uiManager;
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiManager.PassouFase();
            uiManager.PegouJumpTrue();
            audioSource.Play();
            Destroy(this.gameObject);
        }
    }
}
