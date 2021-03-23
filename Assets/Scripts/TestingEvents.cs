using System;
using UnityEngine;

public class TestingEvents : MonoBehaviour
{
    public event EventHandler OnSpacePressed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
        }
    }
}