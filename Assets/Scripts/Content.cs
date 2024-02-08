using UnityEngine;
using System.Collections.Generic;

public class Content : MonoBehaviour
{

    public delegate void ContentAction();
    public static event ContentAction OnContentEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnContentEnter?.Invoke();
        }
    }
}
