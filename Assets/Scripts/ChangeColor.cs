using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//GameObject 1


public class ChangeColor : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnClicked += RandomColor;
    }

    private void OnDisable()
    {
        EventManager.OnClicked -= RandomColor;
    }

    void RandomColor() 
    {
        Color color = new Color(Random.value, Random.value, Random.value);
        gameObject.GetComponent<Renderer>().material.color = color;
    }
}