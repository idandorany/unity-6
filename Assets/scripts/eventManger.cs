using System;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static event Action OnSimpleEvent;
    public static event Action<int> OnIntEvent;
    public static event Action<string, float> OnStringFloatEvent;


    public UnityEvent SimpleEvent;
    public UnityEvent<string> StringEvent;

    public static void TriggerSimpleEvent()
    {
        OnSimpleEvent.Invoke();
    }

    public static void TriggerIntEvent(int value)
    {
        OnIntEvent.Invoke(value);
    }

    public static void TriggerStringFloatEvent(string text, float number)
    {
        OnStringFloatEvent?.Invoke(text, number);
    }
}