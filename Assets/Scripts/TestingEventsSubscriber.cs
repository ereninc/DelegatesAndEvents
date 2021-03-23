using System;
using UnityEngine;

public class TestingEventsSubscriber : MonoBehaviour
{
    private TestingEvents _testingEvents;
    void Start()
    {
        _testingEvents = GetComponent<TestingEvents>();
        _testingEvents.OnSpacePressed += TestingEvents_OnSpacePressed;
    }

    private void TestingEvents_OnSpacePressed(object sender, EventArgs e)
    {
        Debug.Log("Space");
        _testingEvents.OnSpacePressed -= TestingEvents_OnSpacePressed;
    }
}