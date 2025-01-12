using UnityEngine;

public class EventListener : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnSimpleEvent += HandleSimpleEvent;
        EventManager.OnIntEvent += HandleIntEvent;
        EventManager.OnStringFloatEvent += HandleStringFloatEvent;
    }

    private void OnDisable()
    {
        EventManager.OnSimpleEvent -= HandleSimpleEvent;
        EventManager.OnIntEvent -= HandleIntEvent;
        EventManager.OnStringFloatEvent -= HandleStringFloatEvent;
    }

    private void HandleSimpleEvent()
    {
        Debug.Log("Simple event triggered!");
    }

    private void HandleIntEvent(int value)
    {
        Debug.Log($"Int event triggered with value: {value}");
    }

    private void HandleStringFloatEvent(string text, float number)
    {
        Debug.Log($"String and float event triggered: {text}, {number}");
    }
}