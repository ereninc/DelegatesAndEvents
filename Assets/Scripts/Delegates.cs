using UnityEngine;
using System;

public class Delegates : MonoBehaviour
{
    private Action attack;
    void Start()
    {
        attack = punchAttack;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            attack();
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            SetAttack();
        }
    }

    void swordAttack() 
    {
        Debug.Log("Sword Attack!");
    }

    void punchAttack() 
    {
        Debug.Log("Punch Attack!");
    }

    void SetAttack() 
    {
        attack = swordAttack;
    }
}