
using System;
using System.Collections.Generic;
using UnityEngine;

public class EventManager 
{
    private Dictionary<string, Action<object>> eventDictionary;

    private static EventManager eventManager;
    
    //public static EventManager instance
    //{
    //    get
    //    {
    //        if (!eventManager)
    //        {
    //            eventManager = FindObjectOfType(typeof(EventManager)) as EventManager;

    //            if (!eventManager)
    //            {
    //                Debug.LogError("There needs to be one active EventManager script on a GameObject in your scene.");
    //            }
    //            else
    //            {
    //                eventManager.Init();

    //                //  Sets this to not be destroyed when reloading scene
    //                DontDestroyOnLoad(eventManager);
    //            }
    //        }
    //        return eventManager;
    //    }
    //}

    //void Init()
    //{
    //    if (eventDictionary == null)
    //    {
    //        eventDictionary = new Dictionary<string, Action<Dictionary<int, object>>>();
    //    }
    //}

    //public static void StartListening(string eventName, Action<Dictionary<int, object>> listener)
    //{
    //    Action<Dictionary<int, object>> thisEvent;

    //    if (instance.eventDictionary.TryGetValue(eventName, out thisEvent))
    //    {
    //        thisEvent += listener;
    //        instance.eventDictionary[eventName] = thisEvent;
    //    }
    //    else
    //    {
    //        thisEvent += listener;
    //        instance.eventDictionary.Add(eventName, thisEvent);
    //    }
    //}

    //public static void StopListening(string eventName, Action<Dictionary<int, object>> listener)
    //{
    //    if (eventManager == null) return;
    //    Action<Dictionary<int, object>> thisEvent;
    //    if (instance.eventDictionary.TryGetValue(eventName, out thisEvent))
    //    {
    //        thisEvent -= listener;
    //        instance.eventDictionary[eventName] = thisEvent;
    //    }
    //}

    //public static void TriggerEvent(string eventName, Dictionary<int, object> message)
    //{
    //    Action<Dictionary<int, object>> thisEvent = null;
    //    if (instance.eventDictionary.TryGetValue(eventName, out thisEvent))
    //    {
    //        thisEvent.Invoke(message);
    //    }
    //}
}
