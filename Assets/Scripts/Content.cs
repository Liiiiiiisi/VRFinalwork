using UnityEngine;
using System.Collections.Generic;

public class Content : MonoBehaviour
{
    public GameObject content;

    private void Start()
    {
        content = GameObject.FindWithTag("Content");
        Debug.Log("Found2");

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            content.SetActive(true);
            Debug.Log("active");
        }
    }
}
