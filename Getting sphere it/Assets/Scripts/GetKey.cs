using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public BoxCollider boxCollider;
    public KeyCode tecla;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(tecla))
        {
            boxCollider.GetComponent<BoxCollider>().enabled = true;
            Destroy(gameObject);
        }
    }
}

