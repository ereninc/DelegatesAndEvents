using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//GameObject 2

public class TeleportScript : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnClicked += Teleport;
    }

    private void OnDisable()
    {
        EventManager.OnClicked -= Teleport;
    }

    void Teleport() 
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-2f, 2f), transform.position.z);
    }
}
